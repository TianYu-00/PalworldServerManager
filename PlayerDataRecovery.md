# Player Data Recovery For Dedicated Server 
Palworld SteamCMD flags set by the developers will have some files be wiped by SteamCMD during update, which has led to a player data wipe for my server.

And here is how I recovered my player data from a data wipe after updating the game from `v0.1.3.0` to `v0.1.4.0`.   
It will be great if you have a backup of your `SaveGames` folder prior to the new update. If you dont and youre in a situation where you JUST updated and found out that the data got wiped, shut down the server and make a `SaveGames` backup right now. 

What you will need:   
1）python: https://www.python.org/downloads/   
2）.sav to .json converter: https://github.com/cheahjs/palworld-save-tools (This is what i used)   
3）Visual studio code: https://code.visualstudio.com/ (Or whatever modern texteditor you would like to use but i will be using this.)

_Just some references_     
OldName: Tian     
NewName: Test123     
OldId: 3de02178-0000-0000-0000-000000000000     
NewId: 31f9c2ce-0000-0000-0000-000000000000     
Old player .sav: 3DE02178000000000000000000000000.sav        
New player .sav: 31F9C2CE000000000000000000000000.sav     

Steps:   
1) Download and install Python
2) download the .sav - .json converter
3) Now make sure you create a backup of your `SaveGames` folder.
4) Now that you have a backup, you would need to start the server and create your new character with a unique name different from your previous name (we would use this name later on to check your id) (I will call mine Test123).
5) After creating the new character you might need to wait some time for you server to create the new generated player `.sav` file.
6) After the new file is created, you can now shutdown the server.
7) Now that your OLD(`3DE02178000000000000000000000000.sav`) and NEW(`31F9C2CE000000000000000000000000.sav`) player .sav is there inside your `Players` folder we can continue with the next step.
8) Now extract the .sav to .json converter, we will just call this converter from now on.
9) Now that it is extracted, copy your `Level.sav` file to the converter's folder.
10) Now follow [these steps](https://github.com/cheahjs/palworld-save-tools?tab=readme-ov-file#terminal) to convert your `Level.sav` to readable `Level.sav.json`.
11) Now that you have your json file, open up the json file with visual studio code and quick search(for me the hotkey is CTRL+F) for the new character name you entered in previous step.
12) Now loop through the name search to find `"player_uid": "UR PLAYER UID"`, it would be something like this
```
"player_uid": "31f9c2ce-0000-0000-0000-000000000000", #THIS WOULD BE WHERE YOUR PLAYER UID IS 
"player_info": {
"last_online_real_time": 1322848130000,
"player_name": "Test123" #THIS WOULD BE WHERE YOUR NAME IS 
```
12) Now that you know your NEW Player UID, copy and paste your NEW Player UID somewhere for later.
13) Now look up your OLD name and get its Player UID like you did with the NEW name, and copy and paste the old Player UID somewhere for later.
14) Now that you have both the old and new player uid, quick search your NEW Player UID and replace all to something like `TestTestTest123123`
15) Now that all of your NEW Player UID is replaced with `TestTestTest123123`, quick search for your OLD Player UID and replace all with your NEW Player UID.
16) Now that you have replaced all of your OLD Player UID with NEW Player UID, quick search for `TestTestTest123123` and replace all with your OLD Player UID.
17) So right now what you should have is a NEW Player UID replaced with OLD Player UID, and OLD Player UID replaced with NEW Player UID.
18) Ok so now that you have done the above, make sure to save your `Level.sav.json` file.
19) After saving it just exit the program and convert that `Level.sav.json` file back to `Level.sav` using the converter.
20) Now that its converted, make a copy of `Level.sav.json` & `Level.sav` then store it somewhere for easy access.
21) Now go back to your `Players` folder and copy your OLD Player .sav file then paste it inside the converter folder.
22) Now that you have the old .sav file, its time to convert it into `xxxxx.sav.json` file.
23) Now that you have the `.json` file, its time to edit the file so open the file up with visual studio code and quick search your OLD Player UID and replace all with NEW Player UID.
24) Now that you have replaced your OLD Player UID with NEW Player UID, save the file and exit the program.
25) Now, its to time to convert the edited `.json` file back to `.sav` file.
26) After converting it back to `.sav` file, change the name of the file to be exactly the same as your NEW(`31F9C2CE000000000000000000000000.sav`) Player .sav file name.
27) So now what you should have is a newly edited `Level.sav` file and a newly edited OLD Player .sav file using the NEW player .sav file name as such `31F9C2CE000000000000000000000000.sav`. Obviously your player .sav file would be different from mine so be sure not to copy my player .sav file names.
28) Now go to your server's `SaveGames` file and delete the `Level.sav` file and go into your `Players` folder to delete both of your NEW and OLD player .sav.
29) Now paste both of the newly edited files into where they should be.
30) Now you can start your server and test it to see if it worked.
    
31) This method worked perfectly for me so if it didnt work for you, you probably have gone wrong somewhere or you might have a complete different issue.
