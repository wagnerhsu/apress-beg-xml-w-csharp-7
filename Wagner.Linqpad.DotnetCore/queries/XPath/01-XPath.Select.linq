<Query Kind="Program" />

void Main()
{
	var fileName = Path.Combine(Path.GetDirectoryName(Util.CurrentQueryPath),"Sample01.xml");
	XElement root = XElement.Load(fileName);
	string pattern = @"//Property";
	root.XPathSelectElement(pattern).Dump();
}

// Define other methods, classes and namespaces here
