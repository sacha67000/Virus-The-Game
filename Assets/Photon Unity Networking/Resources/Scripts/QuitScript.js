function OnMouseEnter()
{
	this.guiText.color = Color.red;
	this.guiText.fontSize = 250;
}

function OnMouseExit()
{
	this.guiText.color = Color.black;
	this.guiText.fontSize = 200;
}

function OnMouseUp()
{
	Application.Quit();
}