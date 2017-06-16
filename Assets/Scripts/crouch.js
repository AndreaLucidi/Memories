#pragma strict

function Start () {
	
}

function Update () {
 

if (Input.GetKeyDown ("c")) { transform.position.y -= 0.5;
 

     transform.localScale.y = 0.25;

 

}
 

if (Input.GetKeyUp ("c")) { transform.position.y += 0.7;
 

     transform.localScale.y = 1.0;

 

} } 