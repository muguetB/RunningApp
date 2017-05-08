<?php
if($_SERVER["REQUEST_METHOD"] == "POST") {
$xml = file_get_contents('php://input');	
$data = simplexml_load_string($xml);

$xsl = new DOMDocument;
$xsl->load('reguly.xsl');

$proc = new XSLTProcessor;
$proc->importStyleSheet($xsl);

header("Content-type: text/xml; charset=utf-8");
echo $proc->transformTOXML($data);

} else {
    echo 'błąd podczas wysyłania.';
}
?>