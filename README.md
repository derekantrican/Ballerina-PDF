# Ballerina PDF
A small program for providing simple modifications to pages of a PDF

![Program](https://i.imgur.com/6bISCv0.png)



**Download from the releases page:** https://github.com/derekantrican/Ballerina-PDF/releases

#### Used libraries/packages:

- [iText 7 library](https://itextpdf.com/itext7) (under the [AGPL license](https://itextpdf.com/AGPL))
- [Costura.Fody](https://github.com/Fody/Costura)
- [Pdfium](pdfium.org) (using [@pvginkel's](https://github.com/pvginkel) [PdfiumViewer](https://github.com/pvginkel/PdfiumViewer))

Currently, these are the supported functions:

**Removing of pages**

- Even
- Odd
- Specific (e.g. 1,2,5-8,22)

**Rotating of pages by an angle (+ for CW, - for CCW)**

- All
- Even
- Odd
- Specific (e.g. 1,2,5-8,22)

**Merging of PDFs**

- Appending a PDF onto the beginning of another PDF
- Appending a PDF onto the end of another PDF

**Grid editor**

As of version 2.0, this program also sports a nifty grid editor that allows you to see a thumbnail of each page your editing so you know which page you're performing the edit on:

![Grid Editor](https://i.imgur.com/8VpOsId.png)
