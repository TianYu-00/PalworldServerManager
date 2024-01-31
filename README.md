# PalworldServerManager
PalworldServerManager - Simple Server Creation And Managing Tool.   
Official way to create dedicated server: https://tech.palworldgame.com/dedicated-server-guide    

Last Tested Game Version: **`v0.1.3.0`** using PSM: **`v1.0.3`**   
Current PSM Language Options Available: **`English`** **`Chinese`**    

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
*By: [TroubleChute](https://hub.tcno.co/games/palworld/dedicated_server/)*
```
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Inbound -LocalPort 27015,27016,25575 -Protocol TCP -Action Allow
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Outbound -LocalPort 27015,27016,25575 -Protocol TCP -Action Allow
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Outbound -LocalPort 8211,27015,27016,25575 -Protocol UDP -Action Allow
New-NetFirewallRule -DisplayName "Palworld Server" -Direction Inbound -LocalPort 8211,27015,27016,25575 -Protocol UDP -Action Allow
```



**`v1.0.3 RCON preview`**  `CURRENTLY FIXING RCON CANT CONNECT REMOTELY ISSUE`
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/d413651f-4c54-4f88-b0d8-5d10539b48dd" alt="Image1" style="width: 100%; height: auto;">   

**`v1.0.2 preview`**  
<img src="https://github.com/TianYu-00/PalworldServerManager/assets/66271788/5d844f1d-c142-4a98-bc4a-26fd9e1b1601" alt="Image1" style="width: 100%; height: auto;">   
