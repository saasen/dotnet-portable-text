using FluentAssertions;
using Xunit;

namespace PortableText;

public partial class Tests
{
    [Fact]
    public void DeepWeirdLists()
    {
        var result = PortableTextToHtml.Render(@"
[
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""fde2e840a29c"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Item a"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""c16f11c71638"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Item b"", ""marks"": [] }]
    },
    {
        ""listItem"": ""number"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""e92f55b185ae"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Item 1"", ""marks"": [] }]
    },
    {
        ""listItem"": ""number"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""a77e71209aff"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Item 2"", ""marks"": [] }]
    },
    {
        ""listItem"": ""number"",
        ""style"": ""normal"",
        ""level"": 2,
        ""_type"": ""block"",
        ""_key"": ""da1f863df265"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Item 2, a"", ""marks"": [] }]
    },
    {
        ""listItem"": ""number"",
        ""style"": ""normal"",
        ""level"": 2,
        ""_type"": ""block"",
        ""_key"": ""60d8c92bed0d"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Item 2, b"", ""marks"": [] }]
    },
    {
        ""listItem"": ""number"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""6dbc061d5d36"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Item 3"", ""marks"": [] }]
    },
    {
        ""style"": ""normal"",
        ""_type"": ""block"",
        ""_key"": ""bb89bd1ef2c9"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": """", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""289c1f176eab"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""In"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 2,
        ""_type"": ""block"",
        ""_key"": ""011f8cc6d19b"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Out"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""ccfb4e37b798"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""In"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 2,
        ""_type"": ""block"",
        ""_key"": ""bd0102405e5c"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Out"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 3,
        ""_type"": ""block"",
        ""_key"": ""030fda546030"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Even More"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 4,
        ""_type"": ""block"",
        ""_key"": ""80369435aed0"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Even deeper"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 2,
        ""_type"": ""block"",
        ""_key"": ""3b36919a8914"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Two steps back"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""9193cbc6ba54"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""All the way back"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 3,
        ""_type"": ""block"",
        ""_key"": ""256fe8487d7a"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Skip a step"", ""marks"": [] }]
    },
    {
        ""listItem"": ""number"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""aaa"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""New List"", ""marks"": [] }]
    },
    {
        ""listItem"": ""number"",
        ""style"": ""normal"",
        ""level"": 2,
        ""_type"": ""block"",
        ""_key"": ""bbb"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""Next level"", ""marks"": [] }]
    },
    {
        ""listItem"": ""bullet"",
        ""style"": ""normal"",
        ""level"": 1,
        ""_type"": ""block"",
        ""_key"": ""ccc"",
        ""markDefs"": [],
        ""children"": [{ ""_type"": ""span"", ""text"": ""New bullet list"", ""marks"": [] }]
    }
]
");

        result.Should().Be(string.Join("",
            "<ul>",
                "<li>Item a</li>",
                "<li>Item b</li>",
            "</ul>",
            "<ol>",
                "<li>Item 1</li>",
                "<li>",
                    "Item 2",
                    "<ol>",
                        "<li>Item 2, a</li>",
                        "<li>Item 2, b</li>",
                    "</ol>",
                "</li>",
                "<li>Item 3</li>",
            "</ol>",
            "<p></p>",
            "<ul>",
                "<li>",
                    "In",
                    "<ul>",
                        "<li>Out</li>",
                    "</ul>",
                "</li>",
                "<li>",
                    "In",
                    "<ul>",
                        "<li>",
                            "Out",
                            "<ul>",
                                "<li>",
                                    "Even More",
                                    "<ul>",
                                        "<li>Even deeper</li>",
                                    "</ul>",
                                "</li>",
                            "</ul>",
                        "</li>",
                        "<li>Two steps back</li>",
                    "</ul>",
                "</li>",
                "<li>",
                    "All the way back",
                    "<ul>",
                        "<li>Skip a step</li>",
                    "</ul>",
                "</li>",
            "</ul>",
            "<ol>",
                "<li>",
                    "New List",
                    "<ol>",
                        "<li>Next level</li>",
                    "</ol>",
                "</li>",
            "</ol>",
            "<ul>",
                "<li>New bullet list</li>",
            "</ul>"
        ));
    }
}