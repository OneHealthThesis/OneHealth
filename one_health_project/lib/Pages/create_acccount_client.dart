import 'package:flutter/material.dart';
import 'package:one_health_project/classes/classes.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';
import 'package:one_health_project/Widgets/text_fields.dart';

class CreateAccountCPage extends StatefulWidget {
  static String id = 'create_account_client_page';
  @override
  State<CreateAccountCPage> createState() => _CreateAccountCPage();
}

class _CreateAccountCPage extends State<CreateAccountCPage> {

  TextEditingController emailTEC =TextEditingController();
  TextEditingController passwordTEC =TextEditingController();
  TextEditingController confirmPasswordTEC =TextEditingController();
  TextEditingController nameTEC = TextEditingController();
  TextEditingController lastNameTEC =TextEditingController();
  TextEditingController phoneTEC = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Container(
        //Adding a image to the background
        //decoration: ,
          child: Scaffold(
              backgroundColor: Colors.grey[850],
              body: SingleChildScrollView(
                  child: Column(
                    children: [Center(),
                      Image.asset(
                        'assets/clean_app_icon.png',
//Check why images work like this only with this height and width 659.4
                        scale: 0.1,
                        fit: BoxFit.scaleDown,
                        width: 180,
                        height: 180,
                        alignment: Alignment.center,
                      ),
                      SizedBox(height: 40,),
                      _userTextField(),
                      SizedBox(height: 20,),
                      _passwordTextField(),
                      SizedBox(height: 20,),
                      _confirmPasswordTextField(),
                      SizedBox(height: 20,),
                      _nameTextField(),
                      SizedBox(height: 20,),
                      _lastnameTextField(),
                      SizedBox(height: 20,),
                      _phoneNumberTextField(),
                      SizedBox(height: 40,),
                      _buttonSendCode(),
                      SizedBox(height: 20,),
                      _confirmCodeTextField(),
                      SizedBox(height: 40,),
                      _buttonLogin(),
                      SizedBox(height: 40,),
                    ],
                  )
              )
          )
      ),

    );
  }

  Widget _userTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: basicTextField()
          );
        }
    );
  }

  Widget _passwordTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: TextField(
                controller: passwordTEC,
                style: TextStyle(color: Colors.white, fontFamily: 'Inter',),
                obscureText: true,
                cursorColor: Colors.red[900],
                decoration: InputDecoration(
                    icon: Icon(Icons.password, color: Colors.white,),
                    hintText: '*****seña',
                    hintStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelText: 'Contraseña'
                ),
                onChanged: (value) {

                },
              )
          );
        }
    );
  }


  Widget _confirmPasswordTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: TextField(
                controller: confirmPasswordTEC,
                style: TextStyle(color: Colors.white, fontFamily: 'Inter',),
                obscureText: true,
                cursorColor: Colors.red[900],
                decoration: InputDecoration(
                    icon: Icon(Icons.password, color: Colors.white,),
                    hintText: '*****seña',
                    hintStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelText: 'Confirmar Contraseña'
                ),
                onChanged: (value) {

                },
              )
          );
        }
    );
  }


  Widget _nameTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: TextField(
                controller: nameTEC,
                style: TextStyle(color: Colors.white, fontFamily: 'Inter',),
                obscureText: true,
                cursorColor: Colors.red[900],
                decoration: InputDecoration(
                    icon: Icon(
                      Icons.drive_file_rename_outline, color: Colors.white,),
                    hintText: 'Nombre',
                    hintStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelText: 'Nombre'
                ),
                onChanged: (value) {

                },
              )
          );
        }
    );
  }



  Widget _lastnameTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: TextField(
                controller: lastNameTEC,
                style: TextStyle(color: Colors.white, fontFamily: 'Inter',),
                obscureText: true,
                cursorColor: Colors.red[900],
                decoration: InputDecoration(
                    icon: Icon(
                      Icons.drive_file_rename_outline, color: Colors.white,),
                    hintText: 'Apellido',
                    hintStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelText: 'Apellido'
                ),
                onChanged: (value) {

                },
              )
          );
        }
    );
  }

  Widget _phoneNumberTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: TextField(
                controller: phoneTEC,
                style: TextStyle(color: Colors.white, fontFamily: 'Inter',),
                obscureText: true,
                cursorColor: Colors.red[900],
                keyboardType: TextInputType.phone,
                decoration: InputDecoration(
                  icon: Icon(Icons.phone, color: Colors.white,),
                  hintText: 'Nombre Apellido',
                  hintStyle: TextStyle(color: Colors.white,
                      fontFamily: 'Inter',
                      fontWeight: FontWeight.bold),
                  labelStyle: TextStyle(color: Colors.white,
                      fontFamily: 'Inter',
                      fontWeight: FontWeight.bold),
                  labelText: 'Número de teléfono',
                ),
                onChanged: (value) {

                },
              )
          );
        }
    );
  }

  Widget _buttonSendCode() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return SizedBox(
              width: 150,
              child:RaisedButton(
            child: Container(
              padding: EdgeInsets.symmetric(horizontal: 3, vertical: 5.0),
              child: Text('Enviar Código', style: TextStyle(color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold)

              ),
            ),
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(30),
            ),
            onPressed: () {},
            color: Colors.red[900],
            elevation: 10.0,
          ));
        }
    );
  }


  Widget _confirmCodeTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: TextField(
                keyboardType: TextInputType.phone,
                style: TextStyle(color: Colors.white, fontFamily: 'Inter',),
                obscureText: true,
                cursorColor: Colors.red[900],
                decoration: InputDecoration(
                    icon: Icon(Icons.numbers, color: Colors.white,),
                    hintText: '123456',
                    hintStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelStyle: TextStyle(color: Colors.white,
                        fontFamily: 'Inter',
                        fontWeight: FontWeight.bold),
                    labelText: 'Confirmar Código'
                ),
                onChanged: (value) {

                },
              )
          );
        }
    );
  }



  Widget _buttonLogin() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return RaisedButton(
            child: Container(
              padding: EdgeInsets.symmetric(vertical: 15.0),
              child: Text('Crear Cuenta', style: TextStyle(color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold)

              ),
            ),
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(10),
            ),
            onPressed: () {

              var _email = emailTEC.text;
              var _password = passwordTEC.text;
              var _confirmpassword = confirmPasswordTEC.text;
              var _name = nameTEC.text;
              var _lastname = lastNameTEC.text;
              var _phone = phoneTEC.text;



              if(_email != ''&&(_password == _confirmpassword )!= ''&&_name != ''&&_lastname != ''&&_phone != '')
                {
                  print('creating user');

                 register( _name, _email, _password, _phone, _lastname) ;
                 





                }
              else{
                print("Faltan Campos por Rellenar");
              }





            },
            color: Colors.red[900],
            elevation: 10.0,
          );
        }
    );
  }


}

Future<bool> register(String _name,String _email,String _password,String _phone,String _lastname) async{
  const url = 'https://onehealth-prod-onehealth-dkbuug.mo2.mogenius.io/api/account/register';

  var jsonBody = jsonEncode({
   "email":  _email,
    "firstName":_name,
    "lastName": _lastname,
    "phoneNumber" :_phone,
    "password": _password,
    "passwordSHA1": "1",


  });

  final response = await http.post(
      Uri.parse(url),
      body: jsonBody, headers: {
    "Accept": "application/json",
    "content-type": "application/json"
  }
  );

  print("response");
  print(response.statusCode);
  if(response.statusCode == 200) return true;
  else return false;

}
