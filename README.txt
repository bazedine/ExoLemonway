
Utilisation de la plate-forme :  Visual studio 2017 community 

Nuget : ajout de newtonJson permettant la conversion

Modifier le web.conf du projet ASP.NET
      Ajout dans le  web.conf pour bloquer la sécurité dans les formulaires 
      dans <configuration>  <system.web>
      Les lignes suivantes
    <pages validateRequest="false" />
    <httpRuntime requestValidationMode="2.0"/>

Architecture de l’application

Création d’un projet principal Web-service(Console) qui contient 4 sous-projets :

- Sous projet ASP.NET (webServiceExo) -> ajout d’un élément Un web service(asmx) 
Nom : WebServiceFX.asmx

   2 méthodes 
* Fibonacci
* XmlToJson

- Sous projet un Console
      Appelle de la méthode Fibonacci du service web service
      Entrer var int et Affichage du résultat 
      Dans la console
       
- Sous projet winform
   Appel des methodes Fibonacci et XmtToJson
   Entrer  et Affichage dans boite de dialog 
   
- Sous projet WebService.test (Test unitaire)
Pour la méthode Fibonacci
   

Azedine BCHIBCHI

