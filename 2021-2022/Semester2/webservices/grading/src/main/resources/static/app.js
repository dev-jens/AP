function validate() {

	var firstName = document.getElementById('firstName').value;
	var lastName = document.getElementById('lastName').value;
	var grade = document.getElementById('grade').value;
	
	if (firstName == '') {
		alert('Please enter a valid first name.');
		return false;
	}
	
	if (lastName == '') {
		alert('Please enter a valid last name.');
		return false;
	}
	
	if (grade == '') {
		alert('Please enter a valid grade.');
		return false;
	}
}