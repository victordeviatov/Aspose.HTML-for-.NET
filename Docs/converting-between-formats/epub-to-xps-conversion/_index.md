---
title: EPUB to XPS Conversion
type: docs
weight: 110
url: /net/epub-to-xps-conversion/
---

In this article, you will find information on how to convert an [EPUB](https://en.wikipedia.org/wiki/EPUB) to [XPS](https://en.wikipedia.org/wiki/Open_XML_Paper_Specification) and how to use [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) and [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) parameters.

{{% alert color="primary" %}} 

<https://products.aspose.app/html/conversion/epub-to-xps>

{{% /alert %}} 

The static methods of the [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class are primarily used as the easiest way to convert an [EPUB](https://en.wikipedia.org/wiki/EPUB) code into various formats. You can convert [EPUB](https://en.wikipedia.org/wiki/EPUB) to [XPS](https://en.wikipedia.org/wiki/Open_XML_Paper_Specification) in your C# application literally with a single line of code!

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertEPUBToXPS-WithASingleLine.cs" >}}

The following C# code snippet shows how to convert EPUB to XPS using Aspose.HTML for .NET.

1. Open an existing EPUB file;
1. Create an instance of [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions);
1. Use the [Converter.ConvertEPUB](https://apireference.aspose.com/net/html/aspose.html.converters.converter/convertepub/methods/9) method of [Converter](https://apireference.aspose.com/net/html/aspose.html.converters/converter) class to save EPUB as a XPS file. You need to pass the EPUB file stream, [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions), and output file path to the [Converter.ConvertEPUB](https://apireference.aspose.com/net/html/aspose.html.converters.converter/convertepub/methods/9) method to convert EPUB to XPS.

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertEPUBToXPS-ConvertEPUBFileToXPS.cs" >}}
## **Save Options**
[XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) allows you to customize the rendering process. You can specify the [page size](https://apireference.aspose.com/net/html/aspose.html.rendering/renderingoptions/properties/pagesetup), [margins](https://apireference.aspose.com/net/html/aspose.html.drawing/page/properties/margin), [CSS media-type](https://apireference.aspose.com/net/html/aspose.html.rendering/mediatype), etc. The following example shows how to use [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) *and* create an XPS file with custom page-size and background color:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertEPUBToXPS-SpecifyXpsSaveOptions.cs" >}}

To learn more about [XpsSaveOptions](https://apireference.aspose.com/html/net/aspose.html.saving/xpssaveoptions) please read [Fine-Tuning Converters](/html/net/fine-tuning-converters/) article.
## **Output Stream Providers**
If it is required to save files in the remote storage (e.g., cloud, database, etc.) you can implement [ICreateStreamProvider](https://apireference.aspose.com/net/html/aspose.html.io/icreatestreamprovider) interface to have manual control over the file creating process. This interface designed as a callback object to create a stream at the beginning of the document/page (depending on the output format) and release the early created stream after rendering document/page.

Aspose.HTML for .NET provides various types of output formats for rendering operations. Some of these formats produce a single output file (for instance PDF, XPS), others create multiple files (Image formats JPG, PNG, etc.).

The example below shows how to implement and use the your own *MemoryStreamProvider* in the application:

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-MemoryStreamProvider.cs" >}}

{{< gist "aspose-com-gists" "f3606888162b6b9cad4e80c485ee4ec3" "Examples-CSharp-ConvertingBetweenFormats-ConvertEPUBToXPS-SpecifyCustomStreamProvider.cs" >}}
