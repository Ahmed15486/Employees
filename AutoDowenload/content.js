function exportt() {
  document.getElementById("id_export").click(); 
}

function submit() {
  document.getElementById("btnShowOK").click(); 
}


function runForever(){
  	exportt();
	document.querySelector('#md_slt').value = '11';
	submit();
  setTimeout(runForever, 30000);
}

runForever();

