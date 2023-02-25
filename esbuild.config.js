var esbuild = require("esbuild");
var chalk = require("chalk");
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

    var now = new Date();

    if (mode === "dev") {
      console.log(
        "%s [%s]: %s",
        chalk.gray(now.toTimeString()),
        chalk.bgBlue("INFO"),
        "Launched esbuild in dev mode."
      );

      await ctx.watch();
      console.log(
        "%s [%s]: %s",
        chalk.gray(now.toTimeString()),
        chalk.bgGreen("SUCCESS"),
        "Watch mode has enabled. Changes made will trigger a rebuild."
      );

      let { host, port } = await ctx.serve({
        servedir: "public",
      });

      console.log(
        "%s [%s]: %s",
        chalk.gray(now.toTimeString()),
        chalk.bgBlue("INFO"),
        "Serving files from " +
          chalk.yellow("/public") +
          " directory at " +
          chalk.underline(`localhost:${port}`) +
          "."
      );
    } else {
      console.log(
        "%s [%s]: %s",
        chalk.gray(now.toTimeString()),
        chalk.bgGreen("SUCCESS"),
        "Build successful. Latest changes has been written to " +
          chalk.yellow("/public/dist") +
          " directory."
      );
      await ctx.dispose();
    }
  } catch (error) {
    console.log(
      "%s [%s]: %s",
      chalk.gray(now.toTimeString()),
      chalk.bgRed("ERROR"),
      `Something went wrong - ${error}`
    );
    await ctx.dispose();
  }
})();
