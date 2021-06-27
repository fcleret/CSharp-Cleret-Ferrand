#####
##
## Développé sous Visual Studio 2019
## Par Francis CLERET et Antoine FERRAND
##
#####


#####
## Instructions d'installation
#####

Sur le terminal :
- git clone https://github.com/fcleret/CSharp-Cleret-Ferrand.git

Aller dans le dossier "CSharp-clerert-ferrand-master" puis lancer le fichier "TP Csharp.sln" avec VS 2019.


#####
## Informations sur les projets de la solution
#####

- BiblioClass: Comprend la base de données et les entités
- BLL: Business Logic Layer
- Console: Test de l'accès à la BDD en projet console
- UnitTest: Test des méthodes du projet console
- WebApp: Application web
- WindowApp: Application de type client lourd

Attention! Il faut changer le chemin d'accès à la base dans le connectionStrings.

Ex :
<connectionStrings>
    <add name="Database1" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='xXXXXXXXx\NOM_DU_DOSSIER\Database\Database\Database1.mdf';Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>

xXXXXXXXx\NOM_DU_DOSSIER à remplacer par exemple par : C:\user\moi\CSharp-clerert-ferrand-master


Ps: Il faut peut-être aussi "nettoyer la solution" présent comme option dans l'onglet "Générer" du menu de Visual Studio.