# PSM - Simple Server Creation And Managing Tool.   

`#CURRENTLY FIXING RCON CANT CONNECT REMOTELY ISSUE`    
> [!NOTE]
Last Tested Game Version: **`v0.1.4.0`** using PSM: **`v1.0.5`**   
Current PSM Language Options Available: **`English`** **`Chinese`**

> [!IMPORTANT]
> It is recommended that you use the backup feature I implemented in update `v1.0.4` and beyond to backup your saved files just in case updating your game server causes a loss of player progression. This is not a bug from my side but a bug from Palworld's side, so do remember to use the backup feature just in case.

> [!IMPORTANT]
> If you got data wiped after updating the game, check out my guide on how to recover it. It might or might not help but there arent many options out there. [Guide](https://github.com/TianYu-00/PalworldServerManager/blob/897b7ab60dd4125ab35e4f76af7af772d16e0819/PlayerDataRecovery.md)

To allow others to join your server and use the rcon feature remotely, you'll need to configure your firewall to open specific ports and set up port forwarding for those ports.   
Basically:   
`Add RCON port to firewall`   
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
*By: [TroubleChute](https://hub.tcno.co/games/palworld/dedicated_server/)*


**`v1.0.3 RCON preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/d413651f-4c54-4f88-b0d8-5d10539b48dd" alt="Image1" style="width: 100%; height: auto;">   

**`v1.0.4 preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/cdbefcc1-2803-4e51-bfef-86a141fac506" alt="Image1" style="width: 100%; height: auto;">   
Official way to create dedicated server: https://tech.palworldgame.com/dedicated-server-guide    
