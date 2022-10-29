import 'dart:core';

class Consulta {
  final DateTime time;
  final String pet_id;
  final String user_id;

  Consulta({
    required this.time,
    required this.pet_id,
    required this.user_id,
  });

  Map toJson() =>{
    'time': time.toIso8601String(),
    'pet_id': pet_id,
    'user_id': user_id,
  };

  static Consulta fromJson(json) => Consulta(
      time: DateTime.parse(json['time']) ,
      pet_id: json['pet_id'],
      user_id: json['user_id']);



}


class Visita extends Consulta{
  final String place;
  final String doctor;
  final String notes;

  Visita({
    required this.place,
    required this.doctor,
    required this.notes,
    required DateTime time,
    required String pet_id,
    required String user_id
  }): super(time: time, pet_id: pet_id, user_id: user_id);


}



class Alergia extends Consulta{
  final String alergia;
  final String notes;

  Alergia({
    required this.alergia,
    required this.notes,
    required DateTime time,
    required String pet_id,
    required String user_id
  }): super(time: time, pet_id: pet_id, user_id: user_id);

  /*factory Alergia.fromJson(dynamic json) => Alergia(
      alergia: json["alergia"] as String,
      notes: json["notes"] as String,
      time: json["time"] as DateTime,
      pet_id: json["pet_id"] as String,
      user_id: json["user_id"] as String);
  */
  static Alergia fromJson(json) => Alergia(
      alergia: json['alergia'],
      notes: json['notes'],
      time: DateTime.parse( json['time']),
      pet_id: json['pet_id'],
      user_id: json['user_id']);

  @override
  String toString() {
    return '{"alergia": $alergia, "notes": $notes, "time": $time, "pet_id": $pet_id, "user_id": $user_id}';
  }

  Map toJson() =>{
    'alergia': alergia,
    'notes': notes,
    'time': time.toIso8601String(),
    'pet_id': pet_id,
    'user_id': user_id,
  };

}


class Medicamento extends Consulta{
  final String medicine;
  final String dose;
  final String place;
  final String doctor;
  final String notes;

  Medicamento({
    required this.medicine,
    required this.dose,
    required this.place,
    required this.doctor,
    required this.notes,
    required DateTime time,
    required String pet_id,
    required String user_id
  }): super(time: time, pet_id: pet_id, user_id: user_id);
}


class Laboratorio extends Consulta{
  final String prueba;
  final String resultado;
  final String normal;
  final String place;
  final String doctor;
  final String notes;

  Laboratorio({
    required this.prueba,
    required this.resultado,
    required this.normal,
    required this.place,
    required this.doctor,
    required this.notes,
    required DateTime time,
    required String pet_id,
    required String user_id
  }): super(time: time, pet_id: pet_id, user_id: user_id);
}

class Radiologia extends Consulta{
  final String title;
  final String result;
  final String place;
  final String doctor;
  final String notes;

  Radiologia({
    required this.title,
    required this.result,
    required this.place,
    required this.doctor,
    required this.notes,
    required DateTime time,
    required String pet_id,
    required String user_id
  }): super(time: time, pet_id: pet_id, user_id: user_id);


}


class Patologia extends Consulta{
  final String title;
  final String result;
  final String place;
  final String doctor;
  final String notes;

  Patologia({
    required this.title,
    required this.result,
    required this.place,
    required this.doctor,
    required this.notes,
    required DateTime time,
    required String pet_id,
    required String user_id
  }): super(time: time, pet_id: pet_id, user_id: user_id);

}



class Cirugia extends Consulta{
  final String title;
  final String result;
  final String place;
  final String doctor;
  final String notes;

  Cirugia({
    required this.title,
    required this.result,
    required this.place,
    required this.doctor,
    required this.notes,
    required DateTime time,
    required String pet_id,
    required String user_id
  }): super(time: time, pet_id: pet_id, user_id: user_id);
}

class User {
  final String name;
  final String lastname;
  final String user_id;
  final String phone;
  final String password;

  User({
    required this.name,
    required this.user_id,
    required this.password,
    required this.phone,
    required this.lastname,
  });


  Map toJson() =>{
    'name': name,
    'lastname':lastname,
    'user_id':user_id,
    'phone':phone,
    'password':password,
    'passwordSHA1':'1',
  };

  static User fromJson(json) => User(
      name: json['name'] ,
      lastname: json['lastname'] ,
      user_id: json['user_id'] ,
      phone: json['phone'] ,
      password: json['password']
  );


}


class Mascota {
  final String name;
  final String owner_id;
  final String pet_id;
  final DateTime birth_date;
  final String species;
  final String race;
  final String sex;
  final String blood_type;

  Mascota({
    required this.name,
    required this.owner_id,
    required this.pet_id,
    required this.birth_date,
    required this.species,
    required this.race,
    required this.sex,
    required this.blood_type
  });


}

class Registro {
  final String name;
  final String password;
  final String email;
  final String phoneNumber;

  Registro({
    required this.name,
    required this.password,
    required this.email,
    required this.phoneNumber,
  });


  Map toJson() =>{
    'name': name,
    'password': password,
    'email': email,
    'phoneNumber': phoneNumber
  };

  static Registro fromJson(json) => Registro(
      name: json['name'] ,
      password: json['password'],
      email: json['email'],
      phoneNumber: json['phoneNumber']
  );


}


class Login {
  final String name;
  final String password;

  Login({
    required this.name,
    required this.password,

  });


  Map toJson() =>{
    'name': name,
    'password': password
  };

  static Login fromJson(json) => Login(
      name: json['name'] ,
      password: json['password']
  );


}