
Utilisation�de la plate-forme :  Visual studio 2017 community 

Nuget�: ajout de newtonJson permettant la conversion

Modifier le web.conf du projet ASP.NET
      Ajout dans le  web.conf pour bloquer la s�curit� dans les formulaires 
      dans <configuration>  <system.web>
      Les lignes suivantes
    <pages validateRequest="false" />
    <httpRuntime requestValidationMode="2.0"/>

Architecture de l�application

Cr�ation d�un projet principal Web-service(Console) qui contient 4 sous-projets�:

- Sous projet ASP.NET (webServiceExo) -> ajout d�un �l�ment Un web service(asmx)�
Nom�: WebServiceFX.asmx

   2 m�thodes 
* Fibonacci
* XmlToJson

- Sous projet un Console
      Appelle de la m�thode Fibonacci du service web service
      Entrer var int et Affichage du r�sultat 
      Dans la console
       
- Sous projet winform
   Appel des methodes Fibonacci et XmtToJson
   Entrer  et Affichage dans boite de dialog 
   
- Sous projet WebService.test (Test unitaire)
Pour la m�thode Fibonacci
   

Azedine BCHIBCHI

