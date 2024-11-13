require('lualine').setup {
  options = {
    icons_enabled = true,
    theme = 'catppuccin-mocha',
    section_separators = { left = '', right = '' },
    component_separators = { left = '', right = '' },
  },
  sections = {
    lualine_a = {
      {
        'filename',
        path = 1,
      }
    }
  }
}

