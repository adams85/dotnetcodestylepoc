### Code style definition formats

* [.editorconfig](https://editorconfig.org/): general purpose
* [prettier](https://prettier.io/docs/en/index.html): [web dev only] (HTML, CSS, JS, TS, etc.) but [can be configured with .editorconfig](https://prettier.io/docs/en/configuration.html#editorconfig)

Basic rules which are (more or less) available everywhere:  https://github.com/editorconfig/editorconfig/wiki/EditorConfig-Properties

### Candidates for universal rules

* `insert_final_newline = true`
* `trim_trailing_whitespace = true`
* `charset = utf-8-bom` - can be overridden in special cases or specified per file type

Would be nice but problematic:
* `max_line_length` - limited support (e.g. VS or dotnet format doesn't support it), so it needs plugin/extra tool/custom development (e.g. a Roslyn analyzer) to enforce everywhere; a universal soft rule/guideline would probably be beneficial, extremely long lines shouldn't be allowed  - see also https://github.com/editorconfig/editorconfig/issues/387 
* Removing redundant empty lines - no direct support but in .NET it's doable using dotnet format+StyleCop (https://github.com/dotnet/format/issues/1074)

Line endings should be [handled by git](https://docs.github.com/en/get-started/getting-started-with-git/configuring-git-to-handle-line-endings#global-settings-for-line-endings): apart from special cases, commit unix-style, checkout platform-specific (`git config --global core.autocrlf true`).
