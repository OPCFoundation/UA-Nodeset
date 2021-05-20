:: %1 - location of the asp.exe 
del %1\asp.log  /q
%1\asp "..\..\DI\Opc.Ua.Di.NodeSet2.xml" "..\Opc.Ua.Adi.NodeSet2.xml" -e "Opc.Ua.Adi.Model.xml" -s XMLstylesheet -n "http://opcfoundation.org/UA/ADI/"
xcopy %1\asp.log asp.log /y

