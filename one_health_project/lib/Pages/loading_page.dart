import 'package:flutter/material.dart';

class LoadingPage extends StatefulWidget {
  static String id = 'loading_page';
  @override
  State<LoadingPage> createState() => _LoadingPageState();


}

class _LoadingPageState extends State<LoadingPage> {

  @override
  void initState(){
    super.initState();
    _navigatohome();
  }
   _navigatohome()async{
     await Future.delayed(Duration(milliseconds: 2000),(){
       Navigator.pushReplacementNamed(context, 'initial_page');
     });
  }

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
                      scale: 0.1,
                      fit: BoxFit.scaleDown ,
                      width: 180,
                      height: 180,
                      alignment: Alignment.center,
                    ),),
                  ],
                )
            )
        ),
      ),
    );
  }




}
