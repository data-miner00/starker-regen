var esbuild = require("esbuild");
var mode = process.argv[2];

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

    if (mode === "dev") {
      await ctx.watch();
      console.log("watching...");

      let { host, port } = await ctx.serve({
        servedir: "public",
      });

      console.log(`hosted at ${host}:${port}`);
    } else {
      console.log("Build successful.");
    }
  } catch (error) {
    console.error(error);
  }
})();
