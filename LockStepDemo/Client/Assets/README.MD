# 层级关系

ApplicationManager是应用入口做各类Manager模块的初始化
ApplicationStatusManager类管理当前的应用状态

UIManager为UI管理器
GlobalLogicManager管理全局逻辑，用于全局执行的DDOL的代码部分
SystemBase 引用 WorldBase
WorldManager管理WorldBase，管理所有世界类

GameObjectMananger 创建物体

## 关键类

ComponentBase 定义了拥有的实体类EntityBase和当前世界WorldBase

EntityBase定义了所属的世界WorldBase

WorldBase包含了拥有的所有ComponentBase的Type，定义了实体池，Component池，List<SystemBase>， List<EntityBase>，Dictionary<string, SingletonComponent>。以及实体相关的各类事件

SystemBase分为几个层级：ViewSystemBase，负责视觉的系统基类

CreatePerfabSystem创建预制体

CommandComponent，命令组件，用于命令模式

PlayerCommandBase，用于玩家发送指令的组件，由服务器解析玩家指令

# 测试模块

使用[Test(Description="...")]特性为void方法添加测试。在选框的Window->General->Test Runner进行模块测试

# 消息发送模块

所有的消息协议类型在/Assets/Resources/Network/ProtocolInfo.txt/中定义
返回调用同步方法类型在/Assets/Resources/Network/MethodInfo.txt/中定义

Tools -> Protocol -> C# to protocol c#类生成protocol文件
Tools -> Protocol -> protocol to c# 根据protocol文件生成c#类
Tools -> Protocol -> 生成解析代码 自动生成从消息变成消息类的解析代码，保存于/Script/ProtocolGenerate/ProtocolAnalysisService.cs/
Tools -> Protocol -> 生成空解析文件 清除所有的生成代码，但是保留调用接口
Tools -> Protocol -> 清空文件夹 清除所有的生成文件
