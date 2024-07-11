# ECS

ApplicationManager，下述所有生命周期真正的持有者，下述的其他类通过将生命周期函数注册到它的事件中从而进行函数调用。继承了MonoBehaviour类，控制着程序的生命周期。同时也是服务端和客户端交互的第一道关口。

SystemBase持有WorldBase，它是逻辑交互的核心，拥有生命周期，大部分的逻辑处理都应该在它的子类中定义，并且提供操控WorldBase中的EntityBase和ComponentBase的方法。

WorldBase持有EntityBase和SystemBase，它是二者交互的桥梁，作为全局逻辑的处理者而存在。SystemBase中定义的生命周期函数在WorldBase中执行，也可进行对应实体和System的事件派发。通过接受消息后传递命令来控制SystemBase的逻辑处理。

ComponentGroupManager管理所有实体以及它们拥有的ComponentGroup组件组合。实现通过实体访问组件或者通过特定组合获取实体（直接使用SystemBase的组合来获取的就是对应System下的实体）

Entity是实体，或者说是组件的容器，持有World和一系列ComponentBase，与传统的开发模式不同，Entity并不是GameObject，而是对数据的一层抽象，在游戏中作为GameObject的标识以创建与Component之间的联系。将它作为GameObject在场景中使用的方式是挂载MonoEntity脚本，同样可以访问其他组件来进行其他的设置。

ComponentBase持有Entity，纯数据集合（包含一些基本的数据处理函数）。

在Unity编辑器中将GameObject设置为实体的方法：创建GameObject物体并挂载MonoEntity脚本，该脚本会根据设定的Components在启用时自动创建实体联系(注：如果创建了新的Component，请点击Tools/ECS/Gemerate ECS Component Name/选项进行组件更新)。

UI部分不需要实体联系

使用代码生成游戏对象的方式是将其打入AB包或者Resource/Perfabs/文件夹，然后根据名称来调用GameObjectManager.CreateGameObject()方法

# 管理器类

ApplicationManager是应用入口做各类Manager模块的初始化
ApplicationStatusManager类管理当前的应用状态

UIManager为UI管理器
GlobalLogicManager管理全局逻辑，用于全局执行的DDOL的代码部分
WorldManager管理WorldBase，管理所有世界类
NetworkManager，用于提供网络服务的类
ProtocolAnalysisService，用于信息包协议解析的类，使用继承了SyncModule的类定义包体内容。

GlobalEvent，全局事件总线，通过向事件频道注册函数来接受收到对应事件时的回调。

GameObjectManager 创建物体

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

# 消息协议ProtocolMessage

消息协议，s结尾代表发给service消息，c结尾代表发给client的信息

消息基类继承于CsharpProtocolInterface接口，并使用特性例如[Module(10, "ProtocolMessage")]定义消息名和消息码，用于自动生成时解析

继承于基类的消息子类，自动生成消息码，用[MessageMode(SendMode.XXX)]特性标识此消息是发送给客户端还是服务端

定义的消息回调方法和协议信息生成于路径\Client\Assets\Resources\Network\

# 数据库

数据库中需要使用到的表：
存储玩家信息的表：PlayerTable

# 需要同步的文件

Clint的DataClassGenerate的内容替换Server中的Data的内容
Clint的/Resources/Network/替换Server中的/Network/
Clint的/Resources/Data/替换Server中的/Data/
Clint的/Script/ProtocolGenerate/的内容替换/Protocol/的内容
Clint的/Script/Generate/的内容替换/Generate/的内容
