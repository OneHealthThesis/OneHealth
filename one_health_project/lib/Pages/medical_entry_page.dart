import 'package:date_field/date_field.dart';
import 'package:flutter/material.dart';








class MedicalEntryPage extends StatefulWidget {
  static String id = 'medical_entry_page';
  @override
  State<MedicalEntryPage> createState() => _MedicalEntryPage();
}

class _MedicalEntryPage extends State<MedicalEntryPage> {
  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child:Container(
        //Adding a image to the background
        //decoration: ,
        child: Scaffold(
            backgroundColor: Colors.grey[850],
            body: SingleChildScrollView(
                child: Center(
                    child: Column(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [Center(),
                        SizedBox(height: 20,),
                        Padding(padding: EdgeInsets.symmetric(horizontal: 15), child:Text('Introducir Datos de Mascota 1 ',textAlign: TextAlign.left, style: TextStyle(color: Colors.white, fontFamily: 'Inter', fontSize: 30,fontWeight: FontWeight.bold),  ),),
                        SizedBox(height: 40,),
                        _buttonAllergies(),
                        SizedBox(height: 20,),
                        _medicalVisitButton(),
                        SizedBox(height: 20,),
                        _vaccineButton(),
                        SizedBox(height: 20,),
                        _prescriptionButton(),
                        SizedBox(height: 20,),
                        _labTestButton(),
                        SizedBox(height: 20,),
                        _radiologyButton(),
                        SizedBox(height: 20,),
                        _pathologyButton(),
                        SizedBox(height: 20,),
                        _surgeryButton(),
                        SizedBox(height: 20,),
                        _bloodPressureButton(),
                        SizedBox(height: 20,),
                        _oxygenButton(),
                        SizedBox(height: 20,),
                        _bloodGlucoseButton(),
                        SizedBox(height: 20,),
                        _notesButton(),
                        SizedBox(height: 20,),

                        //SizedBox(height: 20,),
                        //_speciesTextField(),
                        //SizedBox(height: 20,),
                        //_speciesTextField(),
                      ],
                    )
                ))
        ),
      ),
    );
  }

  Widget _bloodGlucoseButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Nivel de Glucosa', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'blood_glucose_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }

  Widget _bloodPressureButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Presión', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'blood_preassure_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }

  Widget _oxygenButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Oxígeno', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'oxygen_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }


  Widget _notesButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Notas', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'notes_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }


  Widget _surgeryButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Cirugía', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'surgery_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }


  Widget _pathologyButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Patología', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'pathology_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }


  Widget _radiologyButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Radiología', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'radiology_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }


  Widget _labTestButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Pruebas de Laboratorio', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'lab_tests_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }


  Widget _prescriptionButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Receta', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'prescription_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }

  Widget _vaccineButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Vacuna', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'vaccine_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }

  Widget _buttonAllergies() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
              RaisedButton(
                child: Container(
                  child: Text('Allergias', style: TextStyle(
                      color: Colors.white,
                      fontFamily: 'Inter',
                      fontWeight: FontWeight.bold)

                  ),
                ),
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(10),
                ),
                onPressed: () {
                  Navigator.pushNamed(context,'allergies_page');
                },
                color: Colors.grey[900],
                elevation: 10.0,
              );
        }
    );
  }


  Widget _medicalVisitButton() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return
            RaisedButton(
              child: Container(
                child: Text('Visita Médica', style: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold)

                ),
              ),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              onPressed: () {
                Navigator.pushNamed(context,'medical_visit_page');
              },
              color: Colors.grey[900],
              elevation: 10.0,
            );
        }
    );
  }




  Widget _typesDropdown() {
    String selectedValue = "Ayuno";
    List<DropdownMenuItem<String>> menuItems = [
      DropdownMenuItem(child: Text("Ayuno"),value: "Ayuno"),
      DropdownMenuItem(child: Text("Postprandial"),value: "Postprandial"),
      DropdownMenuItem(child: Text("Postprandial"),value: "Postprandial"),
    ];
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {

          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: DropdownButtonFormField(
                  style: TextStyle(color: Colors.white, fontFamily: 'Inter',),
                  decoration: InputDecoration(
                    labelText: "Tipo",
                  ),
                  dropdownColor: Colors.grey[900],
                  onChanged: (String? newValue) {
                    setState(() {
                      selectedValue = newValue!;
                    });
                  },
                  items: menuItems

              )
          );
        }
    );
  }





  Widget _timeDateTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
            padding: EdgeInsets.symmetric(horizontal: 20.0),
            child: DateTimeFormField(
              dateTextStyle: TextStyle(color: Colors.white),
              decoration: const InputDecoration(
                contentPadding:  EdgeInsets.symmetric(vertical: 29,horizontal: 8),
                hintStyle: TextStyle(color: Colors.white),
                errorStyle: TextStyle(color: Colors.redAccent),
                border: OutlineInputBorder(
                    borderSide: const BorderSide(
                      color: Colors.red,
                      width: 2.0,
                    ),
                    borderRadius: const BorderRadius.all(
                      const Radius.circular(15.0),
                    )
                ),

                suffixIcon: Icon(Icons.event_note),
                labelText: 'Hora y Fecha',
              ),
              mode: DateTimeFieldPickerMode.dateAndTime,
              autovalidateMode: AutovalidateMode.always,
              validator: (e) => (e?.day ?? 0) == 1 ? 'Please not the first day' : null,
              onDateSelected: (DateTime value) {
                print(value);
              },
            ),
          );
        }
    );
  }



  Widget _allergieTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: TextField(
                cursorColor: Colors.red[900],
                style: TextStyle(color: Colors.white, fontFamily: 'Inter',),
                decoration: InputDecoration(
                    hoverColor: Colors.red[900],
                    focusColor: Colors.red[900],
                    hintStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelText: 'Alergia'
                ),
                onChanged: (value) {

                },
              )
          );
        }
    );
  }




  Widget _buttonCancel() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return SizedBox(
              width: 150,
              height: 60,

              child:RaisedButton(
                padding: EdgeInsets.symmetric(vertical: 0),
                child: Container(
                  child: Text('Cancelar', style: TextStyle(
                      color: Colors.white,
                      fontFamily: 'Inter',
                      fontWeight: FontWeight.bold)

                  ),
                ),
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(10),
                ),
                onPressed: () {
                  Navigator.pop(context);
                },
                color: Colors.red[900],
                elevation: 10.0,
              ));
        }
    );
  }

}