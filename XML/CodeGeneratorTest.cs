using System;
namespace MyProject
{
    class CodeGeneratorTest
    {
        public void TestMethod()
        {
            Catalog catalog = new Catalog(@"..\..\exampleXml.xml");
            foreach (Artist artist in catalog.Artist)
            {
                Console.WriteLine(artist.name);
                foreach (Song song in artist.Song)
                {
                    Console.WriteLine("   " + song.Text);
                }
            }
        }
    }
}