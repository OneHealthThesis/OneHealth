import 'package:flutter/material.dart';

//#region TextFields

//Common TextField used through de application for most of text data input
Widget basicTextField(String label, String hint, IconData icon,
    TextInputType keyType, TextEditingController controller) {
  return StreamBuilder(builder: (BuildContext context, AsyncSnapshot snapshot) {
    return Container(
        padding: const EdgeInsets.symmetric(horizontal: 20.0),
        child: TextField(
          controller: controller,
          keyboardType: keyType,
          cursorColor: Colors.red[900],
          style: basicInputTextStyle(),
          decoration: InputDecoration(
            hintText: hint,
            labelText: label,
            hoverColor: Colors.red[900],
            focusColor: Colors.red[900],
            icon: Icon(
              icon,
              color: Colors.white,
            ),
            hintStyle: basicLabelTextStyle(),
            labelStyle: basicLabelTextStyle(),
          ),
          onChanged: (value) {},
        ));
  });
}

//#endregion





//#region TextStyles

TextStyle basicLabelTextStyle() {
  return const TextStyle(
      color: Colors.white, fontFamily: 'Inter', fontWeight: FontWeight.bold);
}

TextStyle basicInputTextStyle() {
  return const TextStyle(color: Colors.white, fontFamily: 'Inter');
}

//#endregion
