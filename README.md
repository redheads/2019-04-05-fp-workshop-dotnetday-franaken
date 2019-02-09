- Framework: [reveal-md](https://github.com/webpro/reveal-md)
- PDF export: [desktape](https://github.com/astefanutti/decktape)

# Initial setup

- `npm install -g reveal-md`
- `npm install -g decktape`

# Normal usage

## Starting the slide show

- `npm start`

## Exporting PDF from slide show

- `npm run pdf`

# Reveal-md basics

`reveal-md` is a convenience wrapper around `revealJs` for people who prefer using markdown instead of plain html. The main advantages is that you only have your content in the Git repo (and none of the reveal-js framework).

The basic command for starting a reveal-md presentation is `reveal-md your-content.md`.

The presentation can be customized:

- from the command line
- from the header section in the markdown file
- from a template file (i.e. reveal.html)

Customization options include:

- css
- reveal configs (i.e. plugins)
- reveal themes

# Project structure

- `reveal.html`: reveal-md format of the standard `index.html` used by reveal-js: include reveal-plugins here
- `package.json`: includes scripts for starting presentation and creating pdf
- `content.md`: obvious...
- `custom.css`: obvious...

