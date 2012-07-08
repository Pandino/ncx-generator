The NcxGen is a command-line tool intended to create the preliminary files needed to authoring eBooks for the Kindle. Given an html file, it can create an optional html Table of Contents (TOC), the global navigation file (NCX) and the metadata file (OPF) to be used with the kindle authoring utility.

ncxgen [options] filename

  -h, -?, --help             Display this help.
      --toc                  Generate the html Table of Contents.
      --ncx                  Generate the NCX Global Navigation.
      --opf                  Create the opf file package.
  -a, --all                  Create both html ToC, ncx and opf files.
  -q, --query=VALUE          The regular expression query to find the ToC items. Use
                               multiple times to add levels in the ToC.
  -l, --level=VALUE          Number of levels to collapse to generate the NCX
                               file - used with -ncx or -all.
      --toc-title=VALUE      Name of the Table of Contents
      --author=VALUE         Author name.
      --title=VALUE          Book title.

Example:
         "ngen.exe -all -q "//h1" -q "//h2[@class='toc']" source.xhtml"

