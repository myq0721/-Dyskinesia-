# CUSGACompetition
for cusga team
---
date: 2023-03-15 22:12:18
---
## 开发工具版本

Unity 2021.3.12f1c2 LTS

## 支持平台

按照顺序优先级

- Windows, Mac, Linux

- Android

- ios

## 版本管理

github

相对来说都更有经验，也更为通用，个人觉得比Unity自带的那个好

另外对于大的设定、需求等，希望策划提前想清楚,写清楚qwq。

## 资源格式

请阅读 : 
[Unity支持的资源类型](https://docs.unity.cn/cn/2021.3/Manual/AssetTypes.html)

建议阅读 : 
[Unity资源工作流程](https://docs.unity.cn/cn/2021.3/Manual/AssetWorkflow.html)

1. 音频建议`统一使用.wav`或其他无损模式(在导入时)

2. 图片建议`统一使用png`

3. 文案可以使用Excel

## 文件目录结构

Assets|

|——Scenes
||——scene文件

|——Scripts
||——场景名称(如场景一:Welcom)/CommontoallScene
|||——功能组(如:BackpackSystem)/CommontoallSystem
||||——cs文件

|——Resources
||——场景名称/CommontoallScene
|||——Texture/Audio
||||——png/wav文件

|——ArtRes
||——场景名称/CommontoallScene
|||——Texture/Audio
||||——png/wav文件

*注意！
备选用的美术,音乐等资源请务必放入  `\assets\ArtRes\场景名称\资源类别\`下,禁止放入`\Resources\`，否则会出现打包后资源过大的问题*


## 文件名规则

1. 见名知意

2. 所有资源原始素材统一使用小写命名，通过下划线"_"来拼接。按照

3. 预设、图集等处理后的资源，命名大写开头

4. 目录名大写开头

5. [注意特殊文件夹名称](https://docs.unity.cn/cn/2021.3/Manual/SpecialFolders.html) : 

Assets, Editor, Editor Default Resources, Gizmos, Resources, Standard Assets, StreamingAssets
, Android Asset Packs

## 代码规范

*一定要注重代码可读性！！！
一定要写注释！！！*

1. 类名： 大小写 例如：UILogin.cs

2. 类变量命名：m开头(例如：mValue)

3. 方法内变量命名:全部小写+下划线 （例如：new_value）或者 下划线开头(例如：_value)

4. 常量全部大写(例如: INT_MAX)


以上规范可大大提高代码可读性，其他如运算符前后要加空格，每一级要加空行，导入库（头文件）后面要加空行，标准库和第三方库的导入分开写……等等最好遵守，养成良好码风哦(*^▽^*)~
