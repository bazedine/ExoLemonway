
Utilisation de la plate-forme :  Visual studio 2017 community 

Nuget : ajout de newtonJson permettant la conversion

Modifier le web.conf du projet ASP.NET
      Ajout dans le  web.conf pour bloquer la securité dans les forrmulaires 
      dans <configuration>  <system.web>
      Les lignes suivantes
    <pages validateRequest="false" />
    <httpRuntime requestValidationMode="2.0"/>

Archietcture de l’application

Creation d’un projet principal Web-service(Console) qui contient 4 sous-projets :

- Sous projet ASP.NET (webServiceExo) -> ajout d’un element Un web service(asmx) 
Nom : WebServiceFX.asmx

   2 méthodes 
* Fibonacci
* XmlToJson

- Sous projet un Console
      Appel de la methode Fibonacci du service web service
      Entrer var int et Affichage du resultat 
      Dans la console
       
- Sous projet winform
   Appel des methodes Fibonacci et XmtToJson
   Entrer  et Affichage dans boite de dialog 
   
- Sous projet WebService.test (Test unitaire)
Pour la méthode Fibonacci
   

Azedine BCHIBCHI

