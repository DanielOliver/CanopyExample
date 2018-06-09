module Tests

open Xunit
open canopy.parallell

[<Fact>]
let ``Hightlight Google Image Test`` () =
    use browser = functions.start canopy.types.Chrome
    functions.url "https://www.google.com" browser
    functions.highlight "#hplogo" browser
    functions.sleep 5
    Assert.True(true)

[<Fact>]
let ``Test Canopy Page`` () =
    use browser = functions.start canopy.types.Chrome
    functions.url "http://lefthandedgoat.github.io/canopy/testpages/" browser
    
    Assert.Equal("Welcome", (functions.element "#welcome" browser).Text)
    Assert.Equal("button not clicked", (functions.element "#button_clicked" browser).Text)
    Assert.Equal("some Nonsense", (functions.element "#button_clicked" browser).Text)
