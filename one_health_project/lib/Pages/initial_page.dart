import 'package:flutter/material.dart';


class InitialPage extends StatefulWidget {
  static String id = 'initial_page';
  @override
  State<InitialPage> createState() => _InitialPageState();
}

class _InitialPageState extends State<InitialPage> {
  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Container(
        child: Scaffold(
            body: Center(
                child: Container(
                    //Expanding Image to full screem
                    constraints: BoxConstraints.expand(),
                    //Adding a image to the background
                    decoration: BoxDecoration(
                        image: const DecorationImage(
                      image: AssetImage('assets/login_page_img1.png'),
                      fit: BoxFit.cover,
                    )),
                    child: Column(
                      mainAxisAlignment: MainAxisAlignment.end,
                      children: [
                        Text('Bienvenido a ',textAlign: TextAlign.left, style: TextStyle(color: Colors.white, fontFamily: 'Inter', fontSize: 60,fontWeight: FontWeight.bold),  ),
                        Text('Saludata ',textAlign: TextAlign.left, style: TextStyle(color: Colors.red[900], fontFamily: 'Inter', fontSize: 60,fontWeight: FontWeight.bold),  ),
                        Flexible(
                          child: Image.asset(
                            'assets/clean_app_icon.png',
//Check why images work like this only with this height and width 659.4
                            scale: 0.1,
                            fit: BoxFit.scaleDown,
                            width: 180,
                            height: 180,
                            alignment: Alignment.center,
                          ),
                        ),
                        SizedBox(
                          height: 40,
                        ),
                        _buttonLogin(),
                        SizedBox(
                          height: 30,
                        ),
                        _createClientAccount(),
                        SizedBox(
                          height: 30,
                        ),
                        _createBussinessAccount(),
                        SizedBox(
                          height: 40,
                        ),
                      ],
                    )))),
      ),
    );
  }

  Widget _buttonLogin() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return RaisedButton(
        child: Container(
          padding: EdgeInsets.symmetric(vertical: 15.0),
          child: Text('Iniciar Sesion',
              style: TextStyle(
                  color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold)),
        ),
        onPressed: () {
          Navigator.pushNamed(context, 'login_page');

        },
        elevation: 10.0,
      );
    });
  }

  Widget _createClientAccount() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return RaisedButton(
        child: Container(
          padding: EdgeInsets.symmetric(vertical: 15.0),
          child: Text('Crear Cuenta Cliente',
              style: TextStyle(
                  color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold)),
        ),
        onPressed: () {
          Navigator.pushNamed(context, 'create_account_client_page');


        },
        elevation: 10.0,
      );
    });
  }

  Widget _createBussinessAccount() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
      return RaisedButton(
        child: Container(
          padding: EdgeInsets.symmetric(vertical: 15.0),
          child: Text('Crear Cuenta Negocios',
              style: TextStyle(
                  color: Colors.white,
                  fontFamily: 'Inter',
                  fontWeight: FontWeight.bold)),
        ),
        onPressed: () {
          Navigator.pushNamed(context, 'create_account_bussiness_page');


        },
        elevation: 10.0,
      );
    });
  }
}
