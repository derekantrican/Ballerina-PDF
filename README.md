# Ballerina PDF
A small program for providing simple modifications to pages of a PDF

![Program](https://i.imgur.com/EKCq9WQ.png)



**Download from the releases page:** https://github.com/derekantrican/Ballerina-PDF/releases

This is a simple program using the [iText 7 library](https://itextpdf.com/itext7) (under the [AGPL license](https://itextpdf.com/AGPL)) that allows for simple modification of PDFs.

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
