# ReeZIP-Cracker

A very simple app that dictionary attacks .ZIP files. Made since I couldn't find a decent free alternative.

Makes use of Ionic.Zip.Reduced.dll v1.9.1.8 from https://dotnetzip.codeplex.com/

The Releases folder has been intentionally kept at the moment for those who don't wish to compile their own, and just want to quickly download this. Those people can download the EXE and required DLL by clicking: [Download Now](https://github.com/Reelix/ReeZIP-Cracker/raw/master/ReeZIP%20Cracker/bin/Release/ReeZIP%20Cracker.zip)

Sample Dictionary File: [Here](https://github.com/praetorian-inc/Hob0Rules/raw/master/wordlists/rockyou.txt.gz) (50.8MB Compressed - 14.3m words - Will need to decompress to use)

Sample Speed: +- 8,500 / second. If you run it inside Visual Studio, this will be reduced to about 100 / second. Rather compile, then run the EXE.

Note that this application is for simpler things. If you're looking for far more intensive ZIP cracking, try [John The Ripper](http://www.openwall.com/john/)

![Sample Speed](https://i.imgur.com/oTj1OWO.png)
