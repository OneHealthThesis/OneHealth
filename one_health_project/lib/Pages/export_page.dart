import 'package:date_field/date_field.dart';
import 'package:flutter/material.dart';





class ExportPage extends StatefulWidget {
  static String id = 'export_page';
  @override
  State<ExportPage> createState() => _ExportPage();
}




class _ExportPage extends State<ExportPage> {

  List<String> DeviceNames = [];

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
                        Padding(padding: EdgeInsets.symmetric(horizontal: 15), child:Text('Exportar Mascota',textAlign: TextAlign.left, style: TextStyle(color: Colors.white, fontFamily: 'Inter', fontSize: 30,fontWeight: FontWeight.bold),  ),),
                        SizedBox(height: 40,),
                        _buttonFind(),
                        SizedBox(height: 20,),

                        Divider(
                          color: Colors.red[900],
                          thickness:8,
                          indent: 1,
                          endIndent: 1,
                        ),
                        SizedBox(height: 20,),
                        _ListView(DeviceNames),
                        SizedBox(height: 20,),
                        Divider(
                          color: Colors.red[900],
                          thickness:8,
                          indent: 1,
                          endIndent: 1,
                        ),
                        SizedBox(height: 20,),
                        //_speciesTextField(),
                        //SizedBox(height: 20,),
                        //_speciesTextField(),
                        _buttonCancel(),
                      ],
                    )
                ))
        ),
      ),
    );
  }

  Widget _buttonFind() {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return SizedBox(
              width: 150,
              height: 60,

              child:RaisedButton(
                child: Container(
                  child: Text('Buscar', style: TextStyle(
                      color: Colors.white,
                      fontFamily: 'Inter',
                      fontWeight: FontWeight.bold)

                  ),
                ),
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(10),
                ),
                onPressed: () {
                  DeviceNames = kk();
                },
                color: Colors.red[900],
                elevation: 10.0,
              ));
        }
    );
  }



Widget _ListView( List<String> DeviceNames) {



    if(DeviceNames.isNotEmpty) {
      List<Widget> ButtonList=[];

      DeviceNames.forEach((name) {
        ButtonList.add(_createDeviceButton(name));
      });
      return StreamBuilder(
          builder: (BuildContext context, AsyncSnapshot snapshot) {
            return Center(child: ListView(children: ButtonList,

            ));
          }
      );
    }
    else return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return Center(child: Center(child: Padding(padding: EdgeInsets.symmetric(horizontal: 15), child:Text('No se ha encontrado ningun dispositivo.',textAlign: TextAlign.left, style: TextStyle(color: Colors.white, fontFamily: 'Inter', fontSize: 20,fontWeight: FontWeight.bold),  ),),

          ));
        }
    );
}


//
// Widget _buttonSend() {
//   return StreamBuilder(
//       builder: (BuildContext context, AsyncSnapshot snapshot) {
//         return SizedBox(
//             width: 150,
//             height: 60,
//
//             child:RaisedButton(
//               padding: EdgeInsets.symmetric(vertical: 0),
//               child: Container(
//                 child: Text('Enviar', style: TextStyle(
//                     color: Colors.white,
//                     fontFamily: 'Inter',
//                     fontWeight: FontWeight.bold)
//
//                 ),
//               ),
//               shape: RoundedRectangleBorder(
//                 borderRadius: BorderRadius.circular(10),
//               ),
//               onPressed: () {
//                 Navigator.pop(context);
//               },
//               color: Colors.red[900],
//               elevation: 10.0,
//             ));
//       }
//   );
// }

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


  Widget _createDeviceButton(String DeviceName) {
    return StreamBuilder(
        builder: (BuildContext context, AsyncSnapshot snapshot) {
          return SizedBox(
              width: 150,
              height: 60,

              child:RaisedButton(
                padding: EdgeInsets.symmetric(vertical: 0),
                child: Container(
                  child: Text(DeviceName, style: TextStyle(
                      color: Colors.white,
                      fontFamily: 'Inter',
                      fontWeight: FontWeight.bold)

                  ),
                ),
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(10),
                ),
                onPressed: () {






                },
                color: Colors.red[900],
                elevation: 10.0,
              ));
        }
    );

  }

List<String> kk(){
    return ["blah"];
}
}
