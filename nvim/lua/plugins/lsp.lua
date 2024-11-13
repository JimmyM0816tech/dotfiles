require("mason").setup()
require("mason-lspconfig").setup({
  ensure_installed = { "lua_ls", "pylsp", "omnisharp" }
})


local capabilities = require('cmp_nvim_lsp').default_capabilities()

require("lspconfig").lua_ls.setup {
  capabilities = capabilities,
}
require("lspconfig").pylsp.setup {
  capabilities = capabilities,
}
require("lspconfig").bashls.setup {
  capabilities = capabilities,
}
require'lspconfig'.omnisharp.setup{
  capabilities = capabilities,
}
