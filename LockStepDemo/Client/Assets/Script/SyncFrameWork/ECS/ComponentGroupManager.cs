using FastCollections;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ComponentGroupManager
{
    private WorldBase world;
    private Dictionary<int, ComponentGroup> allGroupDic = new Dictionary<int, ComponentGroup>();
    private FastList<ComponentGroup> allGroupList = new FastList<ComponentGroup>();
    private Dictionary<ComponentGroup, List<EntityBase>> groupToEntityDic = new Dictionary<ComponentGroup, List<EntityBase>>();
    private Dictionary<EntityBase, List<ComponentGroup>> entityToGroupDic = new Dictionary<EntityBase, List<ComponentGroup>>();

    //优化List<ComponentGroup>
    //private HeapObjectPool<List<ComponentGroup>> objectPool = new HeapObjectPool<List<ComponentGroup>>();
    public Dictionary<int, ComponentGroup> AllGroupDic
    {
        get
        {
            return allGroupDic;
        }
    }

    public Dictionary<ComponentGroup, List<EntityBase>> GroupToEntityDic
    {
        get
        {
            return groupToEntityDic;
        }
    }

    public ComponentGroupManager(WorldBase world)
    {
        this.world = world;
        for (int i = 0; i < world.m_systemList.Count; i++)
        {
            SystemBase system = world.m_systemList[i];
            if (system.Filter.Length == 0)
                continue;
            int key = StringArrayToInt(system.Filter);
            if (allGroupDic.ContainsKey(key))
            {
                //Debug.Log("System :"+ system.GetType().FullName+ "  Filter :" + string.Join(",", system.Filter) + " Dic :"+string.Join(",",allGroupDic[key].Components));
                continue;
            }
            ComponentGroup group = new ComponentGroup(key, system.Filter, world);
            allGroupDic.Add(key, group);
            allGroupList.Add(group);
            groupToEntityDic.Add(group, new List<EntityBase>());
        }
        for (int i = 0; i < world.m_recordList.Count; i++)
        {
            RecordSystemBase system = world.m_recordList[i];
            if (system.Filter.Length == 0)
                continue;
            int key = StringArrayToInt(system.Filter);
            if (allGroupDic.ContainsKey(key))
            {
                //Debug.Log("System :" + system.GetType().FullName + "  Filter :" + string.Join(",", system.Filter) + " Dic :" + string.Join(",", allGroupDic[key].Components));
                continue;
            }

            ComponentGroup group = new ComponentGroup(key, system.Filter, world);
            allGroupDic.Add(key, group);
            allGroupList.Add(group);
            groupToEntityDic.Add(group, new List<EntityBase>());
        }
    }

    public int StringArrayToInt(string[] arr)
    {
        Array.Sort(arr);
        string tempS = string.Join("&", arr);
        return tempS.ToHash();
    }
    /// <summary>
    /// filter是Component的名称
    /// </summary>
    /// <param name="key"></param>
    /// <param name="filters"></param>
    /// <returns></returns>
    public List<EntityBase> GetEntityByFilter(int key, string[] filters)
    {
        ComponentGroup group;
        if (allGroupDic.TryGetValue(key, out group))
        {

        }
        else
        {
            AddGroup(key, filters);
            allGroupDic.TryGetValue(key, out group);
        }
        List<EntityBase> list;
        if (groupToEntityDic.TryGetValue(group, out list))
        {
            if (list != null)
                return list;
        }
        return new List<EntityBase>();
    }
    public List<EntityBase> GetEntityByFilter(string[] filters)
    {
        int key = StringArrayToInt(filters);
      
        return GetEntityByFilter(key,filters);
    }

    public ComponentGroup[] GetGroupByEntity(EntityBase entity)
    {
        List<ComponentGroup> list;
        if (entityToGroupDic.TryGetValue(entity, out list))
        {
            if (list != null)
                return list.ToArray();
        }

        return new ComponentGroup[0];
    }

    private bool AddGroup(int key,string[] filters)
    {
        if( filters==null || filters.Length == 0)
        {
            Debug.LogError("AddGroup 失败，参数不能为空！");
            return false;
        }
        if (allGroupDic.ContainsKey(key))
        {
            Debug.LogError("AddGroup 失败，名字重复！");
            return false;
        }

        ComponentGroup group = new ComponentGroup(key, filters, world);
        allGroupDic.Add(key, group);
        allGroupList.Add(group);

        List<EntityBase> newListEntity = new List<EntityBase>();

        List<EntityBase> listEntity = new List<EntityBase>(entityToGroupDic.Keys);
        for (int i = 0; i < listEntity.Count; i++)
        {
            EntityBase entity = listEntity[i];
            //List<ComponentGroup> newGroupList = GetEntitySuportGroup(entity);
            bool isContains = true;
            for (int j = 0; j < filters.Length; j++)
            {
                if (!entity.GetExistComp(filters[j]))
                {
                    isContains = false;
                }
            }
            if (isContains)
            {
                newListEntity.Add(entity);
                entityToGroupDic[entity].Add(group);
            }
        }
        groupToEntityDic.Add(group, newListEntity);

        return true;
    }

    public void OnEntityCreate(EntityBase entity)
    {
        List<ComponentGroup> newGroupList = GetEntitySuportGroup(entity);

        if (!entityToGroupDic.ContainsKey(entity))
                entityToGroupDic.Add(entity, newGroupList);
            else
                entityToGroupDic[entity] = newGroupList;
        
        for (int i = 0; i < newGroupList.Count; i++)
        {
            List<EntityBase> list = groupToEntityDic[newGroupList[i]];
            //if (!list.Contains(entity))
                list.Add(entity);
        }

    }
    public void OnEntityDestroy(EntityBase entity)
    {
        List<ComponentGroup> list = entityToGroupDic[entity];
        for (int i = 0; i < list.Count; i++)
        {
            groupToEntityDic[list[i]].Remove(entity);
        }
       
        entityToGroupDic.Remove(entity);
        list.Clear();
#if !Server
        HeapObjectPool<List<ComponentGroup>>.PutObject(list);
#endif
    }

    public void OnEntityComponentChange(EntityBase entity, int compIndex, ComponentBase component)
    {
        //Debug.Log("OnEntityComponentChange");
        List<ComponentGroup> oldSystems;
        if (!entityToGroupDic.TryGetValue(entity, out oldSystems))
        {
            oldSystems = new List<ComponentGroup>();
            entityToGroupDic.Add(entity, oldSystems);
        }

        List<ComponentGroup> newGroupList = GetEntitySuportGroup(entity);


        entityToGroupDic[entity] = newGroupList;

        for (int i = 0; i < newGroupList.Count; i++)
        {
            ComponentGroup sys = newGroupList[i];
            if (!oldSystems.Contains(sys))
            {
                List<EntityBase> list = groupToEntityDic[sys];
                if (list == null)
                {
                    list = new List<EntityBase>();
                }
                list.Add(entity);
            }
        }

        for (int i = 0; i < oldSystems.Count; i++)
        {
            ComponentGroup sys = oldSystems[i];
            if (!newGroupList.Contains(sys))
            {
                List<EntityBase> list = groupToEntityDic[sys];
                if (list == null)
                {
                    list = new List<EntityBase>();
                }

                list.Remove(entity);
            }
        }
    }

    public List<ComponentGroup> GetEntitySuportGroup(EntityBase entity)
    {
#if !Server
        List<ComponentGroup> groupNames = HeapObjectPool<List<ComponentGroup>>.GetObject();
        groupNames.Clear();
#else
        List<ComponentGroup> groupNames = new List<ComponentGroup>();
#endif

        for (int i = 0; i < allGroupList.Count; i++)
        {
            ComponentGroup group = allGroupList[i];
            int[] filterCom = group.ComponentHashs;
            bool isContains = true;
            for (int j = 0; j < filterCom.Length; j++)
            {
                if (!entity.GetExistComp(filterCom[j]))
                {
                    isContains = false;
                    break;
                }
            }
            if (isContains)
            {
                groupNames.Add(group);
            }
        }

        return groupNames;
    }
}

