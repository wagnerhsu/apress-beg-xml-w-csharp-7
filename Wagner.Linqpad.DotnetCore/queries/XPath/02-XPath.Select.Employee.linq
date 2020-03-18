<Query Kind="Program" />

void Main()
{
	var fileName = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath), "Employees.xml");
	XElement root = XElement.Load(fileName);
	SelectByProperty(root);
}

// Define other methods, classes and namespaces here
void SelectByProperty(XElement root)
{
	string pattern = @"//employee[@age='23']";
	root.XPathSelectElement(pattern).Dump();
	pattern = @"//employee[@age > '2']";
	root.XPathSelectElement(pattern).Dump();
}