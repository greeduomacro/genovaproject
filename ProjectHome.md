**This project will no longer be updated.**

**This project was supported by Alex Souza Marçal with the help of a few people along in its development.**

**GeNova Project** is based on RunUO 2.0 Server and Scripts and provide a MMORPG Ultima Online (UO) Server with new features and easy configuration, customization, integration with MySQL Database.

**GeNova Project is compatible with:** GNU/Linux, FreeBSD, Microsoft Windows, MacOSX, Platform 32 and 64 Bits.

**GeNova Project runs on:** Mono or .NET Framework.

**GeNova Project supports the following versions of UO:** AOS, SE, ML, Partial support to KR.

**_Genova Project this is brazilian project._**

## **Last Updates: rev. 71 in 12/11/2008 02:06** ##
```
New layer to the project Genova Project: Genova Project Web Application. 
This layer is developed in ASP.NET and aims to integrate the SHARD there is a web portal.
```

# **Download the project in the SOURCE tab.** #

## Installation and Configuration? View DOWNLOADS tab or svn trunk (pdf file). ##

## Other Configurations? View DOWNLOADS tab or svn trunk (pdf file). ##

**This project makes no changes in the Ultima-Online game or any of this file.**

**Softwares (Necessary)**
  * Mono (Latest version) OR .NET FRAMEWORK 3.5 (Recommended);
  * Mysql 5.0+;
  * TortoiseSVN Recommended (Latest version);

**Notes 12/07/2008**
  * Mono Compatible;
  * Compatible with RunUO 2.0 SVN [REVISION 300](https://code.google.com/p/genovaproject/source/detail?r=300);
  * Compatible with [Project Modain's Legacy Full Support](http://code.google.com/p/mondains-legacy/) [revision 12](https://code.google.com/p/genovaproject/source/detail?r=12);
  * Latest test with UO:ML 6.0.9.2;
  * Latest test with UO:KR 2.54.0.7;

**Projects aimed to run KR**
  * [UO:KR Client Loader](http://scriptsharing.dv-team.de/dle/comment.php?dlid=861&ENGINEsessID=16a504cb61f13bc6328262430974405c)
  * [Cheese 1.9.1](http://uodev.de/viewtopic.php?p=35210&highlight=#35210)
**Important: the responsibility to access or download these files is the responsibility of the person concerned. We have no connection with these projects.**

We expect his cooperation to improve support for UO: KR. Please do not fail to send
suggestions on what we need to implement, bugs or suggestions in what is already
implemented. Remember that without the cooperation of all, hardly give greater range of
support. By sending an e-mail, report the greatest amount of detail possible (screens,
images, packets ...) so we can examine the case so deep in order to implement it. Thank
you.

**KR Supports (25/07/2008) (Incomplete Information)**
  * Face System;
  * New Mobile Status Stuff;
  * BackPack and Container (new view);
  * Macro System;
  * Waypoints System;
  * Partial Support for Gumps (Default, OSI);
  * Tools Bar Full Support (Items, Skills and Spells);
  * Creating characters;
  * Delete Character;
  * Item, Spell and Skill Target;
  * Spellbook;
  * Spell Effects, Animation, Movements;
  * and more...

**Others Systems (13/07/2008) (Incomplete Information)**
  * Mobile name and title traduction, using mysql;
  * Additional Loot for Create, using mysql;
  * Experience Points for player, using mysql;
  * Creating Account interactive, using mysql;
  * Unique Name register (_[registrarPersonagem_), using mysql;
  * Global Message (BroadCast), using mysql;
  * Real Status Server for Web page, using mysql;
  * Food Decay;
  * Items Decay;
  * Custom items;
  * Custom Mobiles;
  * Mega Spwaner and ODBC Spawner;
  * Full support Mondain's Legacy (Other project);
  * Custom Race;
  * Random Loot Model;
  * Several settings controlled by XML files;
  * and more...

**Configs (Optional) (24/05/2008)**
```
Config Connection Mysql in: ./GeNova_XML/Configs/mysql.xml

Structure of the Mysql in: ./Mysql_Scripts.sql

Modify/Config your .bat files in: ./

Name Default for Mobile: ./Scripts/_GeNova_/Engines/PersonagemDesconhecido.cs ln 11

Restrict Worlds? ./Scripts/_GeNova_/Engines/PersonagemEmMundoRestrito.cs ln 12

Not Young? ./Scripts/_GeNova_/Engines/StatusLogin.cs ln 36

Address and Name Server: ./Scripts/Misc/ServerList.cs ln 40 and 41

Other Configurations: ./GeNova_XML/Configs/genova.xml
```

**Commands for Project Mondain's Legacy:
```
[SettingsML pops up a settings menu in which you can enable disable various things 

[DecorateML decorates world with various things like questers, deco... (not monsters) 

Quests pops up a quest list from targeted player 
```**

**Configs: Gump KR Register**
```
Edit file: .\GeNova_XML\Misc\gumps.xml
example - added line:
<object name="RessurectGump" value="2223" />

in RessurectGump.cs insert:
public static void Initialize()
{
    RegisterType(typeof(ResurrectGump));
}

Done. This gump is Registered. :)
```


**Want to help? Please contact: souzaemarcal@gmail.com**