package com.example.one_health_project

import android.util.Log
import java.io.*

//class utils {

public fun readFile(path: String, name: String): ByteArray {//path: String) {

    val file = File(path, name)
    val size = file.length().toInt()
    val bytes = ByteArray(size)
    try {
        val buf = BufferedInputStream(FileInputStream(file))
        buf.read(bytes, 0, bytes.size)
        buf.close()
    } catch (e: FileNotFoundException) {

        e.printStackTrace()
    } catch (e: IOException) {

        e.printStackTrace()
    }
    return bytes
}


@Throws(IOException::class)
public fun writeFile(path: String, bFile: ByteArray) {

    Log.d("D", "write File")
    val root = File(path)
    if (!root.exists()) root.mkdirs()
    //SELECT FILE
    val file = File(root, "copy.txt")
    if (!file.exists()) file.createNewFile()
    //writeBytesToFile(bFile, file)

    val jsonString = String(bFile, charset("utf-8"))
    //val userJson = JSONObject(bFile.toString())
    Log.d("D", "write 3.5");
    Log.d("D", jsonString);

}

public fun createFile(path: String, name: String, bFile: ByteArray){
    val root = File(path)
    if (!root.exists()) root.mkdirs()
    //SELECT FILE
    val file = File(root, name)
    if (!file.exists()) file.createNewFile()
    //file.setWritable(true)
    //var empty = byteArrayOf()
    //file.writeBytes(bFile)
    writeBytesToFile(bFile, file)

}


public fun writeBytesToFile(bFile: ByteArray, fileDest: File) {
    try {
        //Log.d("D", "write 4");
        val fOut = FileOutputStream(fileDest)
        fOut.write(bFile)
        Log.d("D", "write 5");
        fOut.close()
        Log.d("D", "write 6");
    } catch (e: IOException) {
        //Log.d("D", "write 6");
        e.printStackTrace()
    }
}