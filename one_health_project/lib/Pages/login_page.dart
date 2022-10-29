import 'package:flutter/material.dart';
import 'package:one_health_project/classes/classes.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class LoginPage extends StatefulWidget {
  static String id = 'login_page';
  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {


  TextEditingController emailTEC =TextEditingController();
  TextEditingController passwordTEC =TextEditingController();

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Container(
        //Adding a image to the background
        //decoration: ,
        child:Scaffold(
        backgroundColor: Colors.grey[850],
          body: Center(
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [Center(),
                  Flexible(child: Image.asset(
                    'assets/clean_app_icon.png',
//Check why images work like this only with this height and width 659.4
                    scale: 0.1,
                    fit: BoxFit.scaleDown ,
                    width: 180,
                    height: 180,
                    alignment: Alignment.center,
                  ),),
                  SizedBox(height: 40,),
                  _userTextField(),
                  SizedBox(height: 20,),
                  _passwordTextField(),
                  SizedBox(height: 40,),
                  _buttonLogin(),
                ],
              )
          )
      ),
      ),
    );
  }

  Widget _userTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Container(
              padding: EdgeInsets.symmetric(horizontal: 20.0),
              child: TextField(
                controller: emailTEC,
                keyboardType: TextInputType.emailAddress,
                cursorColor: Colors.red[900],
                style: TextStyle( color: Colors.white,fontFamily: 'Inter',),
                decoration: InputDecoration(
                  hoverColor:Colors.red[900] ,

                  focusColor: Colors.red[900],
                    icon: Icon(Icons.email, color: Colors.white,),
                    hintText: 'ejemplo@correo.com',
                    hintStyle:  TextStyle( color: Colors.white,fontFamily: 'Inter',fontWeight: FontWeight.bold),
                    labelStyle: TextStyle( color: Colors.white,fontFamily: 'Inter',fontWeight: FontWeight.bold),
                    labelText: 'Correo'
                ),
                onChanged: (value) {

                },
              )
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
                controller: passwordTEC ,
                style: TextStyle( color: Colors.white,fontFamily: 'Inter',),
                obscureText: true,
                decoration: InputDecoration(
                    icon: Icon(Icons.password,color: Colors.white,),
                    hintText: 'Contraseña',
                    hintStyle:  TextStyle( color: Colors.white,fontFamily: 'Inter',fontWeight: FontWeight.bold),
                    labelStyle: TextStyle( color: Colors.white,fontFamily: 'Inter',fontWeight: FontWeight.bold),
                    labelText: 'Contraseña'
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
                      padding: EdgeInsets.symmetric(horizontal: 80.0, vertical: 15.0),
                      child: Text('Iniciar Sesion',style: TextStyle( color: Colors.white,fontFamily: 'Inter', fontWeight: FontWeight.bold)

                      ),
                    ),
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(10),
                    ),
                    onPressed: () {

                      var _password = passwordTEC.text;
                      var _email = emailTEC.text;

                      if(_password != '' && _email != '') {

                        if(login(_email,_password) as bool) {
                          Navigator.pushNamedAndRemoveUntil(
                              context, 'home_page', (route) => false);
                        }



                      }
                      
                      
                    },
                    color: Colors.red[900],
                    elevation: 10.0,
          );
        }
    );
  }

  final PasswordController = TextEditingController();
  final MailController = TextEditingController();

}




Future<bool> login(String email, String password) async {
  const url = 'https://onehealth-prod-onehealth-dkbuug.mo2.mogenius.io/api/account/login';


  var jsonBody = jsonEncode({
    "email": email,
    "password" : password,
    "realEmail": email,
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
  print(response.body);
  if(response.statusCode == 200) return true;
  else return false;
}
