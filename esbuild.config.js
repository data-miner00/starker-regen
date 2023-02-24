var esbuild = require("esbuild");

(async () => {
  try {
    let ctx = await esbuild.context({
      entryPoints: ["src/index.fs.js"],
      bundle: true,
      minify: false,
      format: "iife",
      sourcemap: false,
      outfile: "public/dist/bundle.js",
      publicPath: "/dist",
      loader: {
        ".png": "file",
        ".svg": "file",
        ".jpg": "file",
      },
    });

    await ctx.watch();
    console.log("watching...");

    let { host, port } = await ctx.serve({
      servedir: "public",
    });

    console.log(`hosted at ${host}:${port}`);
  } catch (error) {
    console.error(error);
  }
})();
