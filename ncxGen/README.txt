The NcxGen? is a tool intended to create the preliminary files needed to authoring 
eBooks for the Kindle.

Ncx and opf tool generator from a single XHTML file.

ncxgen [options] filename

  -h, -?, --help             Display this help.
      --toc                  Generate the html Table of Contents.
      --ncx                  Generate the NCX Global Navigation.
      --opf                  Create the opf file package.
  -a, --all                  Create both html ToC, ncx and opf files.
  -q, --query=VALUE          The XPath query to find the ToC items. Use
                               multiple times to add levels in the ToC.
  -l, --level=VALUE          Number of levels to collapse to generate the NCX
                               file - used with -ncx or -all.
      --toc-title=VALUE      Name of the Table of Contents
      --author=VALUE         Author name.
      --title=VALUE          Book title.

Example:
         "ngen.exe -all -q "//h1" -q "//h2[@class='toc']" source.xhtml"

This expression will parse the xhtml file source.xhtml looking for the tag h1 and 
the tag h2 with an attribute class set to 'toc'. It will then create the html Table 
of Contents, the NCX Global Navigation file and the OPF file using the items found.
You can select the level of the content in the toc using the -q (or --query) parameter 
followed by an XPath expression (that I think are quite easy to use at basic level). To 
add multiple levels at the toc, just add more -q with the relative XPath query. One 
option that I create for the Kindle, is the ability to "collapse" the toc levels (or 
part of it) to the root level. An example: your book has 2 main parts divided in chapters. 
You want the chapters to be properly indented in the html toc, but you also want to see 
each chapter mark in the bottom of the Kindle screen. You can use this tool with the 
option -l 2 to put both parts and chapters at the same navigation level (the html toc will 
still be properly indented). One you create the toc.html, the ncx and the opf file, you 
still have to edit the opf one to fix the metadata (or you can use --author and --title) 
and the link to the cover file (by default Cover.jpg). Finally just use the kindlegen tool 
with the opf file just created.