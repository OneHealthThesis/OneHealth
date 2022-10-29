
import 'package:encrypt/encrypt.dart' as encrypt;
import 'package:flutter/material.dart';
//import 'package:permission_handler/permission_handler.dart';

class MyEncryption{


  static final key = encrypt.Key.fromUtf8('1salud2salud3salud4salud5saludPS');
  static final iv = encrypt.IV.fromUtf8('Userpasswordkeys');
  static final encrypter = encrypt.Encrypter(encrypt.AES(key));

  static encryptAES(text){
    final encrypted = encrypter.encrypt(text, iv: iv);

    print(encrypted.bytes);
    print(encrypted.bytes);
    print(encrypted.bytes);

    return encrypted;
  }

  static decryptAES(text){
    return encrypter.decrypt(text, iv: iv);

  }
}

/*Future<bool> requestStoragePErmision() async {
  if (!await Permission.storage.isGranted){
    PermissionStatus result = await Permission.storage.request();
    return result.isGranted;
  }
  return true;
}*/

