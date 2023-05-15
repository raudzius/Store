module.exports = {
  env: { browser: true, es2020: true },
  extends: ['airbnb', 'airbnb-typescript'],
  parser: '@typescript-eslint/parser',
  parserOptions: { project: 'client/tsconfig.json' },
  plugins: ['react-refresh'],
  ignorePatterns: ['.eslintrc.cjs', 'vite.config.ts'],
  rules: {
    'react-refresh/only-export-components': 'warn',
    'react/function-component-definition': [
      2,
      {
        namedComponents: 'arrow-function',
        unnamedComponents: 'arrow-function',
      },
    ],
    'react/require-default-props': [0],
    'import/no-cycle': [0],
  },
};
