<?
$servername = "localhost";
$username = "balbi";
$password = "admin";
$database = "RunningApp";

// Create connection
$conn = new mysqli($servername, $username, $password, $database);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

if($_SERVER["REQUEST_METHOD"] == "POST") {
$string = file_get_contents('php://input');	
$json=json_decode($string, true);
$login = $json['login'];
$password = $json['password'];
$method = $json['method'];

if($method == 'register'){
$device = $json['device'];
$row = mysqli_query($conn, "SELECT COUNT(*) FROM Users WHERE login = '$login' LIMIT 1");
$czyIstnieje = mysqli_fetch_row($row);

if($czyIstnieje[0] > 0){
    echo json_encode(array('userref' => 0)); 
    $ref = 0;
} else{
    $sql = "INSERT INTO Users (login, password, device) VALUES ('$login', '$password', '$device')";
   if(mysqli_query($conn, $sql) === true) {
        $result = mysqli_query($conn, "SELECT id FROM Users");
        $row = mysqli_fetch_row($result);
        $ref=$row[0];
        echo json_encode(array('userref' => $ref));
   }else{
        $ref= 0;
        echo json_encode(array('userref' => $ref));
        //printf("error: %s\n", mysqli_error($conn));
        //echo 'blad podczas dodawania uzytkownika';
    }
}
}
else if($method = 'login'){
$row = mysqli_query($conn, "SELECT COUNT(*) FROM Users WHERE `login` = '$login' AND `password` = '$password' LIMIT 1");
$czyIstnieje = mysqli_fetch_row($row);

if($czyIstnieje[0] == 1){
    $_SESSION['nick'] = $login;
    $_SESSION['haslo'] = $password;
    $status = 1;
    echo json_encode(array('status' => $status));
} else {
   $status = 0;
   echo json_encode(array('status' => $status));
   //printf("error: %s\n", mysqli_error($conn));
}
}
}
mysqli_close($conn);

?>