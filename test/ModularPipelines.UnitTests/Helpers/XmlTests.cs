﻿using System.Xml.Linq;
using ModularPipelines.Context;

namespace ModularPipelines.UnitTests.Helpers;

public class XmlTests : TestBase
{
    [Test]
    public async Task Can_Serialize_With_Null()
    {
        var xml = await GetService<IXml>();

        var result = xml.ToXml(new XmlModel {Foo = "Bar!", Hello = "World!"});
        
        Assert.That(result.Trim(), Is.EqualTo("""
                                       <XmlModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
                                         <Foo>Bar!</Foo>
                                         <Hello>World!</Hello>
                                       </XmlModel>
                                       """));
    }
    
    [Test]
    public async Task Can_Serialize_With_Array()
    {
        var xml = await GetService<IXml>();

        var result = xml.ToXml(new XmlModel
        {
            Foo = "Bar!", 
            Hello = "World!",
            Items = new[] { "One", "Two", "3"}
        });
        
        Assert.That(result.Trim(), Is.EqualTo("""
                                              <XmlModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
                                                <Foo>Bar!</Foo>
                                                <Hello>World!</Hello>
                                                <Items>
                                                  <string>One</string>
                                                  <string>Two</string>
                                                  <string>3</string>
                                                </Items>
                                              </XmlModel>
                                              """));
    }
    
    [Test]
    public async Task Can_Serialize_With_Options()
    {
        var xml = await GetService<IXml>();

        var result = xml.ToXml(new XmlModel {Foo = "Bar!", Hello = "World!"}, 
            SaveOptions.DisableFormatting);
        
        Assert.That(result.Trim(), Is.EqualTo("""
                                       <XmlModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
                                         <Foo>Bar!</Foo>
                                         <Hello>World!</Hello>
                                       </XmlModel>
                                       """));
    }
    
    [Test]
    public async Task Can_Deserialize()
    {
        var xml = await GetService<IXml>();

        var result = xml.FromXml<XmlModel>("""
                                              <XmlModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
                                                <Foo>Bar!</Foo>
                                                <Hello>World!</Hello>
                                              </XmlModel>
                                              """);
        
        Assert.That(result, Is.EqualTo(new XmlModel {Foo = "Bar!", Hello = "World!"}));
    }
    
    [Test]
    public async Task Can_Deserialize_With_Options()
    {
        var xml = await GetService<IXml>();

        var result = xml.FromXml<XmlModel>("""
                                              <XmlModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
                                                <Foo>Bar!</Foo>
                                                <Hello>World!</Hello>
                                              </XmlModel>
                                              """, LoadOptions.None);
        
        Assert.That(result, Is.EqualTo(new XmlModel {Foo = "Bar!", Hello = "World!"}));
    }

    public record XmlModel
    {
        public string? Foo { get; set; }
        public string? Hello { get; set; }
        public string[]? Items { get; set; }
    }
}