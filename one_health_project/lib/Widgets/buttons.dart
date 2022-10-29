import 'package:flutter/material.dart';
import 'package:flutter/material.dart';
import 'package:one_health_project/classes/classes.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

Widget _buttonLogin() {
  return StreamBuilder(
      builder: (BuildContext context, AsyncSnapshot snapshot) {

        TextEditingController emailTEC =TextEditingController();
        TextEditingController passwordTEC =TextEditingController();
        TextEditingController confirmPasswordTEC =TextEditingController();
        TextEditingController nameTEC = TextEditingController();
        TextEditingController lastNameTEC =TextEditingController();
        TextEditingController phoneTEC = TextEditingController();

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

