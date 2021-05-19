:: %1 - location of the asp.exe 
del %1\asp.log  /q
%1\asp "..\Opc.Ua.Di.NodeSet2.xml" -e "Opc.Ua.Di.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/DI/"
xcopy %1\asp.log asp.log /y
