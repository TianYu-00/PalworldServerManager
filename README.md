# PalworldServerManager - Simple server creating and managing tool.    
_DOWNLOAD:_ [Download Latest](https://github.com/TianYu-00/PalworldServerManager/releases/latest)    
[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I1U729N)

> [!NOTE]
Last Tested Game Version: **`v0.1.5.1`** using PSM: **`v1.1.7`**   
Current PSM Language Options Available: **`English`** **`Chinese`**

> [!IMPORTANT]
> It is recommended that you use the backup feature I implemented in update `v1.0.4` and beyond to backup your saved files just in case updating your game server causes a loss of player progression. This is not a bug from my side but a bug from Palworld's side, so do remember to use the backup feature just in case.

> [!IMPORTANT]
> If you got data wiped after updating the game, check out my guide on how to recover it. It might or might not help but there arent many options out there. [Guide](https://github.com/TianYu-00/PalworldServerManager/blob/897b7ab60dd4125ab35e4f76af7af772d16e0819/PlayerDataRecovery.md)

_Installation_
-----------------------
1) Download    
2) Create a new folder    
3) Copy the exe to the new folder    
4) Run the exe    

To allow others to join your server and use the rcon feature remotely, you'll need to configure your firewall to open specific ports and set up port forwarding for those ports.   
Basically:   
`Add Server & RCON port to firewall`   
`Portforward your Server & RCON port.`   

|  Default Ports|Description  |
|--|--|
| 8211 |Server Port  |
| 27015 |Steam Port  |
| 25575 |RCON Port  |

   
Could also open ur firewall ports with script: 
```
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Inbound -LocalPort 27015,27016,25575 -Protocol TCP -Action Allow
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Outbound -LocalPort 27015,27016,25575 -Protocol TCP -Action Allow
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Outbound -LocalPort 8211,27015,27016,25575 -Protocol UDP -Action Allow
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Inbound -LocalPort 8211,27015,27016,25575 -Protocol UDP -Action Allow
```


_Previews_
-----------------------

**`v1.1.5 Server Settings Preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/ecc453e8-b2ba-49e7-ab6d-934219177adc" alt="Image1" style="width: 100%; height: auto;">   

**`v1.1.7 Discord Webhook Preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/7d4b8dc7-4d6e-497b-9df1-cf6cedd3e469" alt="Image1" style="width: 100%; height: auto;">   
In order to use Discord Webhook, you need to fill in your **`Webhook URL`** and save it.    
To test to see if its set up properly, fill in **`Embed Title`** with **`Test123`** or whatever, then save it and press the **`Test`** button.    
Some Webhook notification features do require you to connect to your RCON. You can do that by going to RCON Section, fill out the RCON details then connect to RCON and leave it on.


_Old Previews_
-----------------------

**`v1.1.1 RCON Section Preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/c0b9df48-8f21-4254-8b60-0610870e6fe6" alt="Image1" style="width: 100%; height: auto;">   
**`v1.0.8 server restart schedule preview`**    
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/94c04aa3-db5b-4258-a47d-d30841655f58" alt="Image1" style="width: 100%; height: auto;">   
**`v1.1.3 RCON Demo preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/a143fdfe-d7f8-4ceb-b9f9-16bfffffd968" alt="Image1" style="width: 100%; height: auto;">   
**`v1.1.0 Full preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/5448c663-69ce-467d-bf7c-aea35b0f6fa7" alt="Image1" style="width: 100%; height: auto;">   


 



Official way to create dedicated server: https://tech.palworldgame.com/dedicated-server-guide    

_Credits_
---------------
[Palworld-Rcon-Sharp](https://github.com/calico-crusade/palworld-rcon-sharp)    
[TroubleChute](https://hub.tcno.co/games/palworld/dedicated_server/)
