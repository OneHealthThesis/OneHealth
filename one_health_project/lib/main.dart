import 'package:flutter/material.dart';
import 'package:one_health_project/pages/adding_pet_page.dart';
import 'package:one_health_project/pages/blood_preassure_page.dart';
import 'package:one_health_project/pages/create_account_business.dart';
import 'package:one_health_project/pages/login_page.dart';
import 'package:one_health_project/pages/initial_page.dart';
import 'package:one_health_project/pages/home_page.dart';
import 'package:one_health_project/pages/loading_page.dart';
import 'package:one_health_project/pages/create_acccount_client.dart';
import 'package:one_health_project/pages/allergies_page.dart';
import 'package:one_health_project/pages/blood_glucose_page.dart';
import 'package:one_health_project/pages/export_page.dart';
import 'package:one_health_project/pages/lab_tests_page.dart';
import 'package:one_health_project/pages/medical_visit_page.dart';
import 'package:one_health_project/pages/notes_page.dart';
import 'package:one_health_project/pages/oxygen_page.dart';
import 'package:one_health_project/pages/pathology_page.dart';
import 'package:one_health_project/pages/prescription_page.dart';
import 'package:one_health_project/pages/radiology_page.dart';
import 'package:one_health_project/pages/surgery_page.dart';
import 'package:one_health_project/pages/vaccine_page.dart';
import 'package:one_health_project/pages/medical_entry_page.dart';


void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Saludata',
      debugShowCheckedModeBanner: false,

      //Making the Main theme of the app, any specific theme should be added here
      theme: ThemeData(
          visualDensity: VisualDensity.adaptivePlatformDensity,
          primaryColor: Colors.grey[900],
          accentColor: Colors.red[900],
          focusColor: Colors.red[900],
          highlightColor: Colors.red[900],
          backgroundColor: Colors.grey[900],
          splashColor: Colors.white,
          cursorColor: Colors.red[900],
          indicatorColor: Colors.red,
          fontFamily: 'Inter',

          //Text Theme
          textTheme: TextTheme(),

          //Creating Main Input Theme Data
          inputDecorationTheme: InputDecorationTheme(
            contentPadding:  EdgeInsets.symmetric(vertical: 20,horizontal: 8),
              hintStyle: TextStyle(
                  color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold),
              labelStyle: TextStyle(
                  color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold),
              fillColor: Colors.grey[900],
              filled: true,
              focusedBorder: OutlineInputBorder(
                  borderSide: const BorderSide(
                    color: Colors.red,
                    width: 2.0,
                  ),
                  borderRadius: const BorderRadius.all(
                    const Radius.circular(15.0),
                  )),
              border: new OutlineInputBorder(
                borderRadius: const BorderRadius.all(
                  const Radius.circular(15.0),
                ),
              )),


          //Creating button theme data
          buttonTheme: ButtonThemeData(
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(50),
              ),
              buttonColor: Colors.red[900],
              minWidth: 300,
              splashColor: Colors.white),
          textButtonTheme: TextButtonThemeData()),




      //Creating routes of the application
      initialRoute: InitialPage.id,
      routes: {
        LoadingPage.id: (context) => LoadingPage(),
        LoginPage.id: (context) => LoginPage(),
        InitialPage.id: (context) => InitialPage(),
        HomePage.id:(context) => HomePage(),
        CreateAccountCPage.id:(context) => CreateAccountCPage(),
        CreateAccountBPage.id:(context)=> CreateAccountBPage(),
        AllergiesPage.id:(context)=> AllergiesPage(),
        AddingPetPage.id:(context) => AddingPetPage(),
        BloodGlucosePage.id:(context) => BloodGlucosePage(),
        BloodPreassurePage.id:(context) => BloodPreassurePage(),
        ExportPage.id:(context) => ExportPage(),
        LabTestPage.id:(context) => LabTestPage(),
        MedicalVisitPage.id:(context) => MedicalVisitPage(),
        NotesPage.id:(context) => NotesPage(),
        OxygenPage.id:(context) => OxygenPage(),
        PathologyPage.id:(context) => PathologyPage(),
        PrescriptionPage.id:(context) => PrescriptionPage(),
        RadiologyPage.id:(context) => RadiologyPage(),
        SurgeryPage.id:(context) => SurgeryPage(),
        VaccinePage.id:(context) => VaccinePage(),
        MedicalEntryPage.id:(context) => MedicalEntryPage(),
      },
    );
  }
}
