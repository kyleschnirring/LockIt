# LockIt
![Screenshot](lockit.ico)

LockIt locks down your PC by blocking programs that attackers can use against you. LockIt does not protect you from viruses,malware or ransomeware. Its not an alternative to antivirus, so please use at your own risk. What LockIt attempts to do is greatly reduce the attack surface by blacklisting executables attackers use that come installed by default in Windows 10. LockIt can also lock down the USB ports on your computer or laptop protecting you from someone plugging in a malicious USB and running code. Last but not least LockIt has an option to erase all of the saved WIFI access points that your machine has connected too. This helps prevent your machine from connecting to a rogue access point which attackers frequently set up in order to trick your device into connecting to their malicious network and capturing your data. You must be Admin for LockIt to work correctly and this version is still BETA so please use at your own risk. LockIt is to only be used on Windows 10 and once again LockIt DOES NOT PROTECT YOU FROM VIRUSES OR ANY KIND OF MALWARE so please be careful.

[Download LockIt Here](https://github.com/kyleschnirring/LockIt/files/1799756/LockIt.zip)

# How to use LockIt
Click the image below to watch a quick video on how to use LockIt.
[![How to use LockIt Beta version](https://www.semtexsecurity.com/images/videopic.png)](https://youtu.be/nNrkT_Equxs)
 
# Locking down Executables
![Screenshot](https://www.semtexsecurity.com/images/appslocked.png)

LockIt locks down the executables by writing registry keys in Windows 10. Currently LockIt blocks execution of 40 plus binaries/executables by simply pressing the "Lock Applications" button. Here's the list.

cmd.exe  
powershell.exe  
powershell_ise.exe  
bash.exe  
cscript.exe  
msbuild.exe  
regsrv32.exe  
certutil.exe  
git-bash.exe  
git-cmd.exe  
git-gui.exe  
mshta.exe  
rundll32.exe  
Cdb.exe  
Csc.exe  
Tracker.exe  
Ntsd.exe  
Bginfo.exe  
Kd.exe  
Rcsi.exe  
Dnx.exe  
Csi.exe  
Certreq.exe  
Dbghost.exe  
InstallUtil.exe  
Msxsl.exe  
Regsvcs.exe  
Regasm.exe  
MSDT.exe
Dfsvc.exe  
IEExec.exe  
Control.exe  
CMSTP.exe  
Xwizard.exe  
Fsi.exe  
Obdconf.exe  
windbg.exe  
PresentationHost.exe  
msiexec.exe  
te.exe  
ATBroker.exe  
runscripthelper.exe  
SyncAppvPublishing.exe  
pcalua.exe  
AppVLP.exe  

Yes we know this is alot but better safe than sorry. If LockIt interupts the functionality of a specific program no worries you can always unlock the executables by pressing the "Unlock Applications" button.

# Locking down USB ports
![Screenshot](https://www.semtexsecurity.com/images/usblocked.png)

LockIt can also lock down the USB ports on your computer or laptop protecting you from someone plugging in a malicious USB and running code. This is especially handy since USB sticks can be bought online and configured specifically to grab passwords or data from your machine. Just click the "Lock USB" button and you are good to go.

# Erasing WIFI access points
![Screenshot](https://www.semtexsecurity.com/images/wifideleted.png)

Your device is always looking for the best connection to connect to the Internet. Now think of all the WIFI hotspots or APs you've connected too, it's probably alot. Attackers can set up rogue WIFI access points to trick your device or laptop into connecting to it. By erasing all these access points it greatly reduces the chances of an attacker tricking your device into connecting to it. Plus Windows 10 stores all WIFI passwords in clear text and can be accessed by anyone that has access to your device or laptop. So if your device does get comprimised attackers will not be able to access this data because you've erased it.

# Credits

If you think I did all this research on my own you're nuts. Id like to thank [@subTee](https://twitter.com/subTee), [@mattifestation](https://twitter.com/mattifestation) and many more for their hard work.

