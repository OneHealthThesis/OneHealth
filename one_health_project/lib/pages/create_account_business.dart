import 'package:flutter/material.dart';

class CreateAccountBPage extends StatefulWidget {
  static String id = 'create_account_bussiness_page';
  @override
  State<CreateAccountBPage> createState() => _CreateAccountBPage();
}

class _CreateAccountBPage extends State<CreateAccountBPage> {
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
                children: [
                  Center(),
                  Image.asset(
                    'assets/clean_app_icon.png',
//Check why images work like this only with this height and width 659.4
                    scale: 0.1,
                    fit: BoxFit.scaleDown,
                    width: 180,
                    height: 180,
                    alignment: Alignment.center,
                  ),
                  SizedBox(
                    height: 40,
                  ),
                  _userTextField(),
                  SizedBox(
                    height: 20,
                  ),
                  _passwordTextField(),
                  SizedBox(
                    height: 20,
                  ),
                  _confirmPasswordTextField(),
                  SizedBox(
                    height: 20,
                  ),
                  _nameTextField(),
                  SizedBox(
                    height: 20,
                  ),
                  _phoneNumberTextField(),
                  SizedBox(
                    height: 20,
                  ),
                  _fieldOfExpertiseTextField(),
                  SizedBox(
                    height: 20,
                  ),
                  _addressTextField(),
                  SizedBox(
                    height: 40,
                  ),
                  _buttonSendCode(),
                  SizedBox(
                    height: 20,
                  ),
                  _confirmCodeTextField(),
                  SizedBox(
                    height: 40,
                  ),
                  _buttonLogin(),
                  SizedBox(
                    height: 40,
                  ),
                ],
              )))),
    );
  }

  Widget _userTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return Container(
          padding: EdgeInsets.symmetric(horizontal: 20.0),
          child: TextField(
            keyboardType: TextInputType.emailAddress,
            cursorColor: Colors.red[900],
            style: TextStyle(
              color: Colors.white,
              fontFamily: 'Inter',
            ),
            decoration: InputDecoration(
                hoverColor: Colors.red[900],
                focusColor: Colors.red[900],
                icon: Icon(
                  Icons.email,
                  color: Colors.white,
                ),
                hintText: 'ejemplo@correo.com',
                hintStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelText: 'Correo'),
            onChanged: (value) {},
          ));
    });
  }

  Widget _passwordTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return Container(
          padding: EdgeInsets.symmetric(horizontal: 20.0),
          child: TextField(
            style: TextStyle(
              color: Colors.white,
              fontFamily: 'Inter',
            ),
            obscureText: true,
            cursorColor: Colors.red[900],
            decoration: InputDecoration(
                icon: Icon(
                  Icons.password,
                  color: Colors.white,
                ),
                hintText: '*****seña',
                hintStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelText: 'Contraseña'),
            onChanged: (value) {},
          ));
    });
  }

  Widget _confirmPasswordTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return Container(
          padding: EdgeInsets.symmetric(horizontal: 20.0),
          child: TextField(
            style: TextStyle(
              color: Colors.white,
              fontFamily: 'Inter',
            ),
            obscureText: true,
            cursorColor: Colors.red[900],
            decoration: InputDecoration(
                icon: Icon(
                  Icons.password,
                  color: Colors.white,
                ),
                hintText: '*****seña',
                hintStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelText: 'Confirmar Contraseña'),
            onChanged: (value) {},
          ));
    });
  }

  Widget _nameTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return Container(
          padding: EdgeInsets.symmetric(horizontal: 20.0),
          child: TextField(
            style: TextStyle(
              color: Colors.white,
              fontFamily: 'Inter',
            ),
            obscureText: true,
            cursorColor: Colors.red[900],
            decoration: InputDecoration(
                icon: Icon(
                  Icons.drive_file_rename_outline,
                  color: Colors.white,
                ),
                hintText: 'Nombre Apellido',
                hintStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelText: 'Nombre'),
            onChanged: (value) {},
          ));
    });
  }

  Widget _fieldOfExpertiseTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return Container(
          padding: EdgeInsets.symmetric(horizontal: 20.0),
          child: TextField(
            style: TextStyle(
              color: Colors.white,
              fontFamily: 'Inter',
            ),
            obscureText: true,
            cursorColor: Colors.red[900],
            decoration: InputDecoration(
                icon: Icon(
                  Icons.cases_rounded,
                  color: Colors.white,
                ),
                hintText: 'Veterinario',
                hintStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelText: 'Campo de Servicio'),
            onChanged: (value) {},
          ));
    });
  }

  Widget _addressTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return Container(
          padding: EdgeInsets.symmetric(horizontal: 20.0),
          child: TextField(
            style: TextStyle(
              color: Colors.white,
              fontFamily: 'Inter',
            ),
            obscureText: true,
            cursorColor: Colors.red[900],
            decoration: InputDecoration(
                icon: Icon(
                  Icons.location_on,
                  color: Colors.white,
                ),
                hintText: 'Ejemplo #43, Vedado, La Habana',
                hintStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelText: 'Ubicación de Negocio'),
            onChanged: (value) {},
          ));
    });
  }

  Widget _phoneNumberTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return Container(
          padding: EdgeInsets.symmetric(horizontal: 20.0),
          child: TextField(
            style: TextStyle(
              color: Colors.white,
              fontFamily: 'Inter',
            ),
            obscureText: true,
            cursorColor: Colors.red[900],
            decoration: InputDecoration(
              icon: Icon(
                Icons.phone,
                color: Colors.white,
              ),
              hintText: 'Nombre Apellido',
              hintStyle: TextStyle(
                  color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold),
              labelStyle: TextStyle(
                  color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold),
              labelText: 'Número de teléfono',
            ),
            onChanged: (value) {},
          ));
    });
  }

  Widget _buttonSendCode() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return SizedBox(
          width: 150,
          child: RaisedButton(
            child: Container(
              padding: EdgeInsets.symmetric(horizontal: 3, vertical: 5.0),
              child: Text('Enviar Código',
                  style: TextStyle(
                      color: Colors.white,
                      fontFamily: 'Inter',
                      fontWeight: FontWeight.bold)),
            ),
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(30),
            ),
            onPressed: () {},
            color: Colors.red[900],
            elevation: 10.0,
          ));
    });
  }

  Widget _confirmCodeTextField() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return Container(
          padding: EdgeInsets.symmetric(horizontal: 20.0),
          child: TextField(
            keyboardType: TextInputType.phone,
            style: TextStyle(
              color: Colors.white,
              fontFamily: 'Inter',
            ),
            obscureText: true,
            cursorColor: Colors.red[900],
            decoration: InputDecoration(
                icon: Icon(
                  Icons.numbers,
                  color: Colors.white,
                ),
                hintText: '123456',
                hintStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelStyle: TextStyle(
                    color: Colors.white,
                    fontFamily: 'Inter',
                    fontWeight: FontWeight.bold),
                labelText: 'Confirmar Código'),
            onChanged: (value) {},
          ));
    });
  }

  Widget _buttonLogin() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return RaisedButton(
        child: Container(
          padding: EdgeInsets.symmetric(vertical: 15.0),
          child: Text('Crear Cuenta',
              style: TextStyle(
                  color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold)),
        ),
        shape: RoundedRectangleBorder(
          borderRadius: BorderRadius.circular(10),
        ),
        onPressed: () {
          Navigator.pushNamedAndRemoveUntil(
              context, 'home_page', (route) => false);
        },
        color: Colors.red[900],
        elevation: 10.0,
      );
    });
  }
}
