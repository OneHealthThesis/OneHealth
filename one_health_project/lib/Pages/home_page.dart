import 'package:flutter/material.dart';

class HomePage extends StatefulWidget {
  static String id = 'home_page';
  @override
  State<HomePage> createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  @override
  Widget build(BuildContext context) {
    return DefaultTabController(length: 2, child: SafeArea(
      child: Container(
        //Adding a image to the background
        //decoration: ,
        child:Scaffold(
            backgroundColor: Colors.grey[850],
            body: Center(
                child: Column(
                  children: [
                    AppBar(backgroundColor: Colors.black,),
                    SizedBox(height: 30),
                    Center(),
                    Padding(padding: EdgeInsets.symmetric(horizontal: 15), child:Text('Bienvenido',textAlign: TextAlign.left, style: TextStyle(color: Colors.white, fontFamily: 'Inter', fontSize: 30,fontWeight: FontWeight.bold),  ),),
                    SizedBox(height: 30),
                    TabBar(tabs: [
                      Tab(text: 'Propias',
                       ),
                      Tab(text: 'Prestadas',),
                    ]),
                    SizedBox(height: 90,
                    child:TabBarView(children: [
                    Padding(padding:EdgeInsets.symmetric(horizontal: 10,vertical: 5),
                          child:Scaffold(backgroundColor: Colors.grey[900],
                              body: Container(
                                child: Row(children: [Center(),
                                      Text("Mascota 1",style: TextStyle(fontSize: 20, color: Colors.white),),SizedBox(width: 50,),
                                  Padding(padding:EdgeInsets.symmetric(horizontal: 10,vertical: 5),child:SizedBox(width: 50,child: RaisedButton(onPressed:(){},),)),
                                  Padding(padding:EdgeInsets.symmetric(horizontal: 10,vertical: 5),child:SizedBox(width: 50,child: RaisedButton(onPressed:(){
                                    Navigator.pushNamed(context, 'export_page');

                                  },),)),
                                  Padding(padding:EdgeInsets.symmetric(horizontal: 10,vertical: 5),child:SizedBox(width: 50,child: RaisedButton(onPressed:(){
                                    Navigator.pushNamed(context, 'medical_entry_page');
                                  },),)),
                                    ],)
                                ),

                          )
                      ),

                      Padding(padding:EdgeInsets.symmetric(horizontal: 10,vertical: 5),
                          child:Scaffold(backgroundColor: Colors.grey[900],
                            body: Container(
                                child: Row(children: [Center(),
                                  Text("Mascota 2",style: TextStyle(fontSize: 20, color: Colors.white),),SizedBox(width: 200,),
                                  Padding(padding:EdgeInsets.symmetric(horizontal: 10,vertical: 5),child:SizedBox(width: 50,child: RaisedButton(onPressed:(){

                                  },),)),
                                ],)
                            ),

                          )
                      ),

                    ]
                    ),),
                    
                    SizedBox(height: 40,),
                    Center(child: _buttonAdd(),),
                    SizedBox(height: 20,),
                    SizedBox(height: 40,),


                  ],
                 
                )
            )
        ),
      ),
    )
    );
  }


  Widget _buttonAdd() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return SizedBox(
              width: 150,
              height: 60,

              child:RaisedButton(
                child: Container(
                  child: Text('Añadir', style: TextStyle(
                      color: Colors.white,
                      fontFamily: 'Inter',
                      fontWeight: FontWeight.bold)

                  ),
                ),
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(10),
                ),
                onPressed: () {
                  Navigator.pushNamed(context,'adding_pet_page');
                },
                color: Colors.red[900],
                elevation: 10.0,
              ));
        }
    );
  }


}
