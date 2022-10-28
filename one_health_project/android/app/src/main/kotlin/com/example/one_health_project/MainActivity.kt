package com.example.one_health_project

import android.Manifest
//import android.annotation.SuppressLint
import android.app.AlertDialog
import android.content.BroadcastReceiver
import android.content.Context
import android.content.Intent
import android.content.IntentFilter
import android.content.pm.PackageManager
import android.location.LocationManager
import android.net.wifi.WifiConfiguration
import android.net.wifi.WifiManager
//import android.net.wifi.WifiManager.LocalOnlyHotspotReservation
import android.net.wifi.p2p.WifiP2pConfig
import android.net.wifi.p2p.WifiP2pDevice
import android.net.wifi.p2p.WifiP2pInfo
import android.net.wifi.p2p.WifiP2pManager
import android.net.wifi.p2p.WifiP2pManager.*
import android.os.*
import android.os.StrictMode.ThreadPolicy
import android.provider.Settings
import android.util.Log
import android.widget.*
//import androidx.annotation.RequiresApi
import androidx.core.app.ActivityCompat
//import androidx.core.content.ContextCompat
import io.flutter.embedding.android.FlutterActivity
import io.flutter.embedding.engine.FlutterEngine
import io.flutter.plugin.common.MethodChannel
import org.json.JSONObject
import java.io.*
import java.net.InetAddress
import java.net.InetSocketAddress
import java.net.ServerSocket
import java.net.Socket
import java.util.concurrent.Executors


var socket: Socket? = null




class MainActivity :FlutterActivity() {



    private val CHANNEL = "com.example.untitled7";
    //var context = applicationContext

    private lateinit var channel: MethodChannel


    override fun onCreate(savedInstanceState: Bundle?) {
        Log.d("me", "entered on Create");
        super.onCreate(savedInstanceState)
        Log.d("me", "entered on Create");

        manager = getSystemService(WIFI_P2P_SERVICE) as WifiP2pManager
        val wchannel = manager!!.initialize(this, mainLooper, null)
        receiver = WifiDirectBroadcastReceiver(manager, wchannel, this)
        this.wchannel = wchannel

        //ReceiverStarter?.start()

        InitializeWork()
    }

    var manager: WifiP2pManager? = null
    var wchannel: Channel? = null


    /*var ReceiverStarter: Thread? = object : Thread(Runnable { }) {

        override fun run() {
            manager = getSystemService(WIFI_P2P_SERVICE) as WifiP2pManager
            val Wchannel = manager!!.initialize(activity, mainLooper, null)
            receiver = WifiDirectBroadcastReceiver(manager, Wchannel, activity as MainActivity)
            wchannel = Wchannel
        }
    }*/


    private val wifimanager : WifiManager get() = this.applicationContext.getSystemService(Context.WIFI_SERVICE) as WifiManager
    //lateinit var wifiManager: WifiManager
    //private var mReservation: LocalOnlyHotspotReservation? = null
    private val PERMISSIONS_REQUEST_CODE = 1

    //private var netConfig: WifiP2pConfig? = null
    private var netConfig: WifiConfiguration? = null



    //var resultList = ArrayList<ScanResult>()


    //var connectionStatus: TextView? = null
    var messageTextView:TextView? = null
    var aSwitch: Button? = null
    var discoverButton:Button? = null
    var listView: ListView? = null
    var typeMsg: EditText? = null
    var sendButton: ImageButton? = null




    var receiver: BroadcastReceiver? = null
    var intentFilter: IntentFilter? = null








    private fun InitializeWork() {


        intentFilter = IntentFilter()
        intentFilter!!.addAction(WifiP2pManager.WIFI_P2P_STATE_CHANGED_ACTION)
        intentFilter!!.addAction(WifiP2pManager.WIFI_P2P_PEERS_CHANGED_ACTION)
        intentFilter!!.addAction(WifiP2pManager.WIFI_P2P_CONNECTION_CHANGED_ACTION)

        this.connectionInfoListener = ConInfoListener(this)

        //registerReceiver(receiver, intentFilter)
        val policy: ThreadPolicy? = ThreadPolicy.Builder().permitAll().build()
        StrictMode.setThreadPolicy(policy)
    }

    override fun onResume() {
        super.onResume()
        Log.d("D", "onResume");
        registerReceiver(receiver, intentFilter)
    }

    override fun onPause() {
        super.onPause()
        Log.d("D", "onResume");
        unregisterReceiver(receiver)
    }






    private fun on_off_wifi() {
        //aSwitch!!.setOnClickListener {
        val intent = Intent(Settings.ACTION_WIFI_SETTINGS)
        startActivityForResult(intent, 1)
        //}
    }


    var peers = mutableListOf<WifiP2pDevice>() // = listOf(WifiP2pDevice)//ArrayList()
    var deviceNameArray = mutableListOf<String>()
    var deviceArray= mutableListOf<WifiP2pDevice>()




    var peerListListener =
            PeerListListener { wifiP2pDeviceList ->
                if (wifiP2pDeviceList != peers) {

                    //Log.d("D", "error 1");

                    peers.clear()
                    //Log.d("D", "error 2");
                    peers.addAll(wifiP2pDeviceList.deviceList)
                    Log.d("D", "error 3");
                    //deviceNameArray = arrayOfNulls(wifiP2pDeviceList.deviceList.size)
                    //deviceArray = arrayOfNulls(wifiP2pDeviceList.deviceList.size)
                    val index = 0
                    for (device in wifiP2pDeviceList.deviceList) {
                        Log.d("D", device.deviceName);
                        deviceNameArray.add(device.deviceName)
                        deviceArray.add(device)
                        //index += 1;
                    }
                    Log.d("D", "error 5");
                    /*val adapter =
                        ArrayAdapter(applicationContext, R.layout.simple_list_item_1, deviceNameArray)*/
                    //Log.d("D", "error 6");
                    //listView!!.adapter = adapter
                    if (peers.size == 0) {
                        //connectionStatus!!.text = "No Hay Dispositivos"
                        //return@PeerListListener
                    }
                }

            }


    //discoverButton.setOnClickListener(new View.OnClickListener() {
    //   @Override
    //   public void onClick(View view){
    //       wifimanager.
    //    }
    //});



    private fun discoverDevices() {

        Log.d("me", "work");
        //connectionStatus = findViewById(R.id.connection_status)
        /*messageTextView = findViewById(R.id.messageTextView)
        listView = findViewById(R.id.listView)
        typeMsg = findViewById(R.id.editTextTypeMsg)*/


        Log.d("D", "discover devices0");



        if (ActivityCompat.checkSelfPermission(
                        this,
                        Manifest.permission.ACCESS_FINE_LOCATION
                ) != PackageManager.PERMISSION_GRANTED
        ) {
            if (ActivityCompat.shouldShowRequestPermissionRationale(
                            activity, Manifest.permission.ACCESS_FINE_LOCATION)){
                ActivityCompat.requestPermissions(activity, arrayOf(Manifest.permission.ACCESS_FINE_LOCATION), 1)
            } else {
                ActivityCompat.requestPermissions(activity, arrayOf(Manifest.permission.ACCESS_FINE_LOCATION), 1)

            }
            // TODO: Consider calling
            //    ActivityCompat#requestPermissions
            // here to request the missing permissions, and then overriding
            //  public void onRequestPermissionsResult(int requestCode, String[] permissions,
            //                                          int[] grantResults)
            // to handle the case where the user grants the permission. See the documentation
            // for ActivityCompat#requestPermissions for more details.
            Log.d("D", "discover devices fail");
            return
        }



        Log.d("D", "discover devices2");
        manager!!.discoverPeers(wchannel, object : ActionListener{
            //@SuppressLint("SetTextI18n")
            override fun onSuccess() {
                Log.d("me", "conn4");


                //connectionStatus!!.text  = "Discovery Started"



            }

            //@SuppressLint("SetTextI18n")
            override fun onFailure(i: Int) {
                Log.d("me", "conn5");
                //connectionStatus!!.text = "Discovery not Started"

            }
        })
    }

    /*val connectionInfoListener =
        ConnectionInfoListener { wifiP2pInfo ->
            //Log.d("me", "Info Listener");
            //override fun onConnectionInfoAvailable(WifiP2pInfo wifiP2pInfo)
                val groupOwnerAddress = wifiP2pInfo.groupOwnerAddress
                if (wifiP2pInfo.groupFormed && wifiP2pInfo.isGroupOwner) {

                    isHost = true
                    serverClass = ServerClass()
                    serverClass!!.start()
                    if (groupOwnerAddress != null) {
                        Log.d("me", "Server");
                    }
                } else {
                    isHost = false
                    if (groupOwnerAddress != null) {
                        clientClass = ClientClass(groupOwnerAddress, activity = MainActivity())
                        clientClass!!.start()
                    }
                }


        }*/

    class ConInfoListener( activity: MainActivity) : ConnectionInfoListener {

        private val activity = activity
        override fun onConnectionInfoAvailable(wifiP2pInfo: WifiP2pInfo?) {

            val groupOwnerAddress = wifiP2pInfo?.groupOwnerAddress
            if (wifiP2pInfo != null) {
                if (wifiP2pInfo.groupFormed && wifiP2pInfo.isGroupOwner) {
                    activity.isHost = true
                    Log.d("D", "I AM SERVER");
                    activity.serverClass = ServerClass(activity)
                    activity.serverClass!!.start()
                } else {
                    activity.isHost = false
                    if (groupOwnerAddress != null) {
                        Log.d("D", "I AM CLIENT");
                        activity.clientClass = ClientClass(groupOwnerAddress, activity = activity)
                        activity.clientClass!!.start()
                        Log.d("D", "Created Client");
                    }
                }
            }
        }

    }

    lateinit var connectionInfoListener : ConInfoListener //= //ConInfoListener(this)



    //CLIENT AND SERVER
    var serverClass: ServerClass? = null
    var clientClass: ClientClass? = null

    var isHost = false


    fun sendText(bytes: ByteArray?) {
        val executor = Executors.newSingleThreadExecutor()
        //
        // USES typeMsg to send text to connected device
        //
        //val msg = typeMsg!!.text.toString()
        val msg = ""
        executor.execute {
            if (isHost) {
                //serverClass!!.write(msg.toByteArray())
                Log.d("me", "send host");
                serverClass!!.write(bytes)
            } else {
                if (!isHost) {
                    //clientClass!!.write(msg.toByteArray())
                    Log.d("me", "send client");
                    if (clientClass == null)
                        Log.d("me", "null client");
                    clientClass!!.write(bytes)
                }
            }
        }
    }

    //
    // CONNECT FUNCTION
    //
    //var policy: ThreadPolicy? = ThreadPolicy.Builder().permitAll().build()

    lateinit var deviceNameConnect: String
    /*
        var ConnectClass: Thread? = object : Thread(Runnable { }) {
            override fun run() {
                Log.d("D", "conn 0");
                var device: WifiP2pDevice? = null
                for (item in deviceArray){
                    if (item.deviceName == deviceNameConnect)
                        device = item
                }
                if (device == null)
                    return
                //var device = deviceArray[0]
                val config = WifiP2pConfig()
                Log.d("D", "conn 1");
                config.deviceAddress = device.deviceAddress
                if (ActivityCompat.checkSelfPermission(
                        activity,
                        Manifest.permission.ACCESS_FINE_LOCATION
                    ) != PackageManager.PERMISSION_GRANTED
                ) {
                    if (ActivityCompat.shouldShowRequestPermissionRationale(
                            activity, Manifest.permission.ACCESS_FINE_LOCATION)){
                        ActivityCompat.requestPermissions(activity, arrayOf(Manifest.permission.ACCESS_FINE_LOCATION), 1)
                    } else {
                        ActivityCompat.requestPermissions(activity, arrayOf(Manifest.permission.ACCESS_FINE_LOCATION), 1)

                    }
                    // TODO: Consider calling
                    //    ActivityCompat#requestPermissions
                    // here to request the missing permissions, and then overriding
                    //   public void onRequestPermissionsResult(int requestCode, String[] permissions,
                    //                                          int[] grantResults)
                    // to handle the case where the user grants the permission. See the documentation
                    // for ActivityCompat#requestPermissions for more details.
                    Log.d("D", "conn 2");
                    return //false
                }
                Log.d("D", "conn 3");
                manager!!.connect(wchannel, config, object : ActionListener {
                    override fun onSuccess() {}
                    override fun onFailure(i: Int) {}
                })
                Log.d("D", "conn 4");
                return //true
            }
        }*/
    fun connect(): Boolean {
        //Select DEVICE
        var device: WifiP2pDevice? = null
        for (item in deviceArray){
            if (item.deviceName == deviceNameConnect)
                device = item
        }
        if (device == null)
            return false
        //    val device = deviceArray[0]
        val config = WifiP2pConfig()
        Log.d("D", "conn 1");
        config.deviceAddress = device.deviceAddress
        if (ActivityCompat.checkSelfPermission(
                        this,
                        Manifest.permission.ACCESS_FINE_LOCATION
                ) != PackageManager.PERMISSION_GRANTED
        ) {
            // TODO: Consider calling
            //    ActivityCompat#requestPermissions
            // here to request the missing permissions, and then overriding
            //   public void onRequestPermissionsResult(int requestCode, String[] permissions,
            //                                          int[] grantResults)
            // to handle the case where the user grants the permission. See the documentation
            // for ActivityCompat#requestPermissions for more details.
            Log.d("D", "conn 2");
            return false
        }
        Log.d("D", "conn 3");
        manager!!.connect(wchannel, config, object : ActionListener {
            override fun onSuccess() {
                Log.d("D", "success");
            }
            override fun onFailure(i: Int) {
                Log.d("D", "failure");
                Log.d("D", i.toString());
            }
        })
        Log.d("D", "conn 4");
        return true
    }




    class ClientClass(hostAddress: InetAddress, activity: MainActivity) : Thread() {

        var hostAdd: String = hostAddress.hostAddress as String
        private var inputStream: InputStream? = null
        private var outputStream: OutputStream? = null
        private val context = activity

        fun write(bytes: ByteArray?) {
            try {
                Log.d("D", "client 1");
                outputStream!!.write(bytes)
                Log.d("D", "client 2");
            } catch (e: IOException) {
                e.printStackTrace()
            }
        }


        override fun run() {
            try {

                //socket = Socket()
                Log.d("D", "client 3");
                socket!!.connect(InetSocketAddress(hostAdd, 8888), 600)
                inputStream = socket!!.getInputStream()
                outputStream = socket!!.getOutputStream()
            } catch (e: IOException) {
                e.printStackTrace()
            }
            Log.d("D", "client 4");
            val executor = Executors.newSingleThreadExecutor()
            val handler = Handler(Looper.getMainLooper())
            executor.execute {
                val buffer = ByteArray(1024)
                var bytes: Int
                while (socket != null) {
                    try {
                        bytes = inputStream!!.read(buffer)
                        if (bytes > 0) {
                            val finalBytes = bytes
                            handler.post {
                                val tempMSG = String(buffer, 0, finalBytes)
                                //Toast.makeText( intent, "File received", Toast.LENGTH_LONG).show()
                                //messageTextView


                                //val path = context.getExternalFilesDir(null)
                                //Log.d("D", path2.toString());
                                //writeFile(path.toString(), buffer)
                                //val data = String(buffer, charset("utf-8"))
                                val data = String(buffer, 0, bytes)
                                context.sendJsonToFlutter(data)

                            }
                        }
                    } catch (e: IOException) {
                        e.printStackTrace()
                    }
                }
            }
        }

        init {
            socket = Socket()
        }

    }


    class ServerClass(activity: MainActivity) : Thread() {
        var serverSocket: ServerSocket? = ServerSocket(8888)
        private val context = activity
        private var inputStream: InputStream? = null
        private var outputStream: OutputStream? = null

        fun write(bytes: ByteArray?) {
            try {
                Log.d("D", "server 1");
                outputStream!!.write(bytes)
                Log.d("D", "server 1");
            } catch (e: IOException) {
                e.printStackTrace()
            }
        }


        override fun run() {
            try {
                //serverSocket = ServerSocket(8000)
                //NEW SOCKET
                //newSocket = serverSocket!!.accept()
                inputStream = socket?.getInputStream()
                outputStream = socket?.getOutputStream()
            } catch (e: IOException) {
                e.printStackTrace()
            }
            val executor = Executors.newSingleThreadExecutor()
            val handler = Handler(Looper.getMainLooper())
            executor.execute {
                val buffer = ByteArray(1024)
                var bytes: Int
                while (true) {
                    try {
                        bytes = inputStream!!.read(buffer)
                        if (bytes > 0) {
                            val finalBytes = bytes
                            handler.post { val tempMSG = String(buffer, 0, finalBytes)


                                val path = context.getExternalFilesDir(null)
                                //Log.d("D", path2.toString());
                                writeFile(path.toString(), buffer)

                            }
                        }
                    } catch (e: IOException) {
                        e.printStackTrace()
                    }
                }
            }
        }
        init {
            Log.d("D", "aceppted server");
            socket = serverSocket!!.accept()
        }
    }





    // LOCATION STATUS AND PERMISSION
    fun statusCheckLocation() {
        val manager = getSystemService(LOCATION_SERVICE) as LocationManager
        if (!manager.isProviderEnabled(LocationManager.GPS_PROVIDER)) {
            buildAlertMessageNoGps()
        }
    }



    fun buildAlertMessageNoGps() {
        val builder = AlertDialog.Builder(this)
        builder.setMessage("La localizacion no esta habilitada, desea habilitarla?")
                .setCancelable(false)
                .setPositiveButton(
                        "Si"
                ) { dialog, id -> startActivity(Intent(Settings.ACTION_LOCATION_SOURCE_SETTINGS)) }
                .setNegativeButton(
                        "No"
                ) { dialog, id -> dialog.cancel()
                    return@setNegativeButton}
        val alert = builder.create()
        alert.show()
    }

    fun statusCheckWifi() {
        //netConfig
        if (!wifimanager.isWifiEnabled){
            buildAlertMessageNoWifi()
        }
    }

    fun buildAlertMessageNoWifi() {
        val builder = AlertDialog.Builder(this)
        builder.setMessage("La Wifi no esta habilitada, desea habilitarla?")
                .setCancelable(false)
                .setPositiveButton(
                        "Si"
                ) { dialog, id -> startActivity(Intent(Settings.ACTION_WIFI_SETTINGS)) }
                .setNegativeButton(
                        "No"
                ) { dialog, id -> dialog.cancel()
                    return@setNegativeButton}
        val alert = builder.create()
        alert.show()
    }


    fun sendJsonToFlutter(jsonData: String){
        Log.d("D", "Send To Flutter")
        Log.d("D", jsonData)
        channel.invokeMethod("receiveJson", jsonData);
    }

    fun sendByteArrayToFlutter(bytes: ByteArray){
        Log.d("D", "Send To Flutter")
        Log.d("D", bytes.toString())
        channel.invokeMethod("receiveBytes", bytes);
    }

    //@RequiresApi(Build.VERSION_CODES.O)

    //@RequiresApi(Build.VERSION_CODES.O)
    override fun configureFlutterEngine(flutterEngine: FlutterEngine) {
        super.configureFlutterEngine(flutterEngine)

        channel = MethodChannel(flutterEngine.dartExecutor.binaryMessenger, CHANNEL)

        channel.setMethodCallHandler {call, result ->



            if(call.method == "wifi"){


                statusCheckWifi()
                statusCheckLocation()
                discoverDevices()

                /*if (peers.size > 0){
                    deviceNameConnect = deviceArray[0].deviceName
                    Log.d("D", "try connect");
                    //ConnectClass?.start()
                    connect()
                    Log.d("D", "tried");
                }*/

                result.success(deviceNameArray)


            }

            if(call.method == "sendfile"){
                try {
                    //on_off_wifi()
                    //discoverDevices()
                    //val path = "Internal storage/testing/"
                    Log.d("D", "tried 1");
                    val path = this.getExternalFilesDir(null)
                    //Log.d("D", path2.toString());
                    Log.d("D", "tried 2");
                    //var bytes = readFile(path.toString(), "otros.txt")
                    //writeFile(path.toString(), bytes)
                    Log.d("D", "tried 3");

                    if (serverClass == null)
                        Log.d("D", "null server");

                    if (clientClass == null)
                        Log.d("D", "null client");

                    val user = UserJson("Paco", 32)
                    var bytes = user.toString().toByteArray()
                    sendText(bytes)

                    Log.d("D", "tried 4");
                    result.success(0)
                }
                catch (e: NullPointerException){
                    Log.d("D", "null pointer");
                }


            }

            if(call.method == "sendJsonFile"){
                try {
                    //on_off_wifi()
                    //discoverDevices()
                    //val path = "Internal storage/testing/"


                    val json = call.argument<String>("name")

                    //val user = UserJson("Paco", 32)
                    var bytes = json?.toByteArray()
                    sendText(bytes)

                    //Log.d("D", "tried 4");
                    result.success(0)
                }
                catch (e: NullPointerException){
                    Log.d("D", "null pointer");
                }


            }

            if (call.method == "createFile"){
                val name = call.argument<String>("name")
                val bFile = call.argument<ByteArray>("bytes")
                val path = this.getExternalFilesDir(null)

                Log.d("D", "flutter file");
                Log.d("D", bFile.toString());
                if (name != null) {
                    if (bFile != null) {
                        createFile(path.toString() ,name, bFile)
                    }
                }

            }

            if (call.method == "readFile"){
                val name = call.argument<String>("name")
                val path = this.getExternalFilesDir(null)

                var fbytes : ByteArray? = null
                if (name != null) {
                    fbytes = readFile(path.toString(), name)
                }

                if (fbytes != null) {
                    sendByteArrayToFlutter(fbytes)
                }

            }

            if(call.method == "connect"){
                deviceNameConnect = call.argument<String>("name").toString()
                connect()


            }


        }


    }




}


public class UserJson(name: String, age: Int): JSONObject() {
    val name = name
    val age = age

    override fun toString(): String {
        return "User{" +
                "name='" + name + '\'' +
                ", age=" + age + "}"


    }

}