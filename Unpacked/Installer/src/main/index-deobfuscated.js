"use strict";

const {
  app: c,
  shell: d,
  BrowserWindow: o,
  ipcMain: t
} = require("electron");
if (c.requestSingleInstanceLock() === false) {
  c.quit();
}
if (c.isPackaged === true && c.isDefaultProtocolClient("polytoria") === false) {
  c.setAsDefaultProtocolClient("polytoria");
}
const k = require("fs");
const n = require("path");
const e = require("os");
const a = require("child_process");
const {
  getProxySettings: m
} = require("get-proxy-settings");
const C = require("undici");
const s = require("node-7z");
const r = require("7zip-bin");
let R = e.platform();
const P = c.getVersion();
const S = "PolytoriaLauncher/" + P;
const O = c.getAppPath();
const Q = c.getPath("userData");
const l = n.join(c.getPath("temp"), "Polytoria");
const i = n.join(Q, "Updater");
const N = n.join(Q, "Client");
const f = n.join(Q, "Creator");
const G = r.path7za.replace("app.asar" + n.sep, "");
const h = n.join(Q, "Settings.json");
let J;
let u;
let H;
let q;
let y;
let p;
if (R === "win32") {
  R = "windows";
  J = c.isPackaged === true ? n.dirname(c.getPath("exe")) : O;
  u = n.join(J, "Polytoria.exe");
  H = "Updater.exe";
  q = "Polytoria Client.exe";
  y = "Polytoria Creator.exe";
} else if (R === "darwin") {
  R = "macos";
  J = c.isPackaged === true ? n.join(c.getPath("exe"), "..", "..", "..") : O;
  u = n.join(J, "Contents", "MacOS", "Polytoria");
  H = "Updater";
  q = n.join("Polytoria Client.app", "Contents", "MacOS", "Polytoria Client");
  y = n.join("Polytoria Creator.app", "Contents", "MacOS", "Polytoria Creator");
} else {
  R = "linux";
  J = c.isPackaged === true ? n.dirname(c.getPath("exe")) : O;
  u = n.join(J, "Polytoria");
  H = "Updater";
  q = "Polytoria Client.x86_64";
  y = "Polytoria Creator.x86_64";
}
const M = {
  type: null,
  token: null
};
let x = null;
async function B() {
  for (const W of process.argv) {
    if (W.startsWith("polytoria://") === false) {
      continue;
    }
    const c = W.replace("polytoria://", "").split("/");
    M.type = c[0] ?? null;
    M.token = c[1] ?? null;
    M.map = c.slice(2).join("/");
    break;
  }
  if (M.type === null || M.token === null) {
    await d.openExternal("https://polytoria.com/places");
    return c.quit();
  }
  const k = (await m())?.https?.toString();
  if (k !== undefined) {
    C.setGlobalDispatcher(new ProxyAgent(k));
  }
  x = new o({
    width: 600,
    height: 240,
    center: true,
    fullscreenable: false,
    title: "Polytoria Launcher",
    show: false,
    frame: false,
    transparent: true,
    webPreferences: {
      devTools: false,
      preload: n.join(O, "src", "preload", "index.js"),
      webgl: false,
      spellcheck: false,
      enableWebSQL: false,
      v8CacheOptions: "none"
    }
  });
  x.setResizable(false);
  x.setMenu(null);
  x.once("closed", () => {
    x = null;
  });
  await x.loadFile("src/renderer/index.html");
  x.show();
  process.on("uncaughtException", W => v(undefined, W));
  process.on("unhandledRejection", W => v(undefined, W));
  await E();
}
async function Z(c) {
  await x?.webContents.send("status", c);
}
async function L(c) {
  x?.setProgressBar(1);
  await x?.webContents.send("success", c);
}
async function v(c, d, o) {
  console.error(d);
  let k = c ?? "An unknown error has occurred";
  if (d !== undefined) {
    k += e.EOL + d.message;
  }
  x?.setProgressBar(1, {
    mode: "error"
  });
  await x?.webContents.send("error", k, o);
}
async function V(c) {
  const o = Math.min(Math.max(c, 0), 100);
  const t = Math.min(Math.max(o / 100, 0), 1);
  x?.setProgressBar(t);
  await x?.webContents.send("progress", o);
}
async function w() {
  x?.setProgressBar(-1);
  await x?.webContents.send("progress", 0);
}
function b(c) {
  return c?.constructor === Object && Object.keys(c).length > 0;
}
function T(c) {
  return Array.isArray(c) === true && c.length > 0;
}
function U(c) {
  return typeof c === "string" && c.trim().length > 0;
}
function z(c) {
  if (c?.hostname === "api.polytoria.com") {
    return M.token;
  } else {
    return undefined;
  }
}
function A() {
  const t = {
    Manifest: {
      Client: [],
      Creator: [],
      Updater: []
    },
    SkipUpdates: false
  };
  let n = null;
  if (k.existsSync(h) === true) {
    let W;
    try {
      n = k.readFileSync(h, "utf8");
      W = JSON.parse(n);
    } catch {}
    if (b(W) === true) {
      if (b(W.Manifest) === true) {
        if (T(W.Manifest.Client) === true) {
          t.Manifest.Client.push(...g(W.Manifest.Client));
        }
        if (T(W.Manifest.Creator) === true) {
          t.Manifest.Creator.push(...g(W.Manifest.Creator));
        }
        if (T(W.Manifest.Updater) === true) {
          t.Manifest.Updater.push(...g(W.Manifest.Updater));
        }
      } else {
        if (U(W.ClientVersion) === true) {
          t.Manifest.Client.push({
            Release: "Stable",
            Version: W.ClientVersion,
            InstalledAt: new Date().toJSON()
          });
        }
        if (U(W.CreatorVersion) === true) {
          t.Manifest.Creator.push({
            Release: "Stable",
            Version: W.CreatorVersion,
            InstalledAt: new Date().toJSON()
          });
        }
        if (U(W.UpdaterVersion) === true) {
          t.Manifest.Updater.push({
            Release: "Stable",
            Version: W.UpdaterVersion,
            InstalledAt: new Date().toJSON()
          });
        }
      }
      if (typeof W.SkipUpdates === "boolean") {
        t.SkipUpdates = W.SkipUpdates;
      }
    }
  }
  const a = JSON.stringify(t);
  if (a !== n) {
    k.writeFileSync(h, a + e.EOL);
  }
  return t;
}
function g(c) {
  const o = [];
  for (const W of c) {
    if (b(W) === true && U(W.Release) === true && U(W.Version) === true && U(W.InstalledAt) === true) {
      const c = {
        Release: W.Release,
        Version: W.Version,
        InstalledAt: W.InstalledAt
      };
      o.push(c);
    }
  }
  return o;
}
function F(c, d) {
  const t = A();
  if (Object.hasOwn(t.Manifest, c) === false) {
    return null;
  } else {
    return t.Manifest[c].find(W => W.Release === d) ?? null;
  }
}
function D(c, d, o) {
  const n = A();
  if (Object.hasOwn(n.Manifest, c) === false) {
    return false;
  }
  n.Manifest[c] = n.Manifest[c].filter(W => W.Release !== d);
  n.Manifest[c].push({
    Release: d,
    Version: o,
    InstalledAt: new Date().toJSON()
  });
  k.writeFileSync(h, JSON.stringify(n) + e.EOL);
}
async function E() {
  (async function (c) {
    await x?.webContents.send("version", c);
  })(P);
  Z("Loading launcher settings...");
  const o = M.type === "client" || M.type === "clientbeta";
  const t = M.type === "test" || M.type === "testbeta";
  const e = M.type === "creator" || M.type === "creatorbeta";
  if (o === false && t === false && e === false) {
    return v("Invalid launch type argument");
  }
  const m = M.type === "clientbeta" || M.type === "testbeta" || M.type === "creatorbeta" ? "Beta" : "Stable";
  let r;
  let O;
  let Q;
  let h;
  try {
    r = A();
    O = F("Updater", "Stable")?.Version ?? null;
    Q = F("Client", m)?.Version ?? null;
    h = F("Creator", m)?.Version ?? null;
  } catch (sW) {
    return v("Failed to parse launcher settings", sW);
  }
  Z("Checking for outdated files...");
  try {
    B = Q;
    b = h;
    if (U(K = O) === true) {
      $(i, K, H);
    }
    if (U(B) === true) {
      $(N, B, q);
    }
    if (U(b) === true) {
      $(f, b, y);
    }
  } catch (rW) {
    return v("Failed to migrate legacy installations", rW);
  }
  var K;
  var B;
  var b;
  if (r.SkipUpdates === true) {
    if (o === true || t === true) {
      j(Q, t);
    } else if (e === true) {
      Y(h);
    }
    return;
  }
  let T;
  Z("Checking for updates...");
  try {
    const W = new URL("https://api.polytoria.com/v1/launcher/updates");
    const {
      body: c
    } = await C.request(W, {
      headers: {
        authorization: z(W),
        "user-agent": S
      },
      query: {
        os: R,
        release: m.toLowerCase()
      },
      throwOnError: true
    });
    T = await c.json();
  } catch (RW) {
    return v("Failed to check for updates", RW.response?.data.Errors?.length > 0 ? RW.response.data.Errors[0] : RW);
  }
  if (T.Maintenance === true) {
    return v("We are currently undergoing maintenance");
  }
  if (U(T.Updater?.Version) === true && U(T.Updater?.Download) === true && (p === "updater" || O === null || O !== T.Updater.Version)) {
    try {
      await (X = new URL(T.Updater.Download), g = T.Updater.Release, E = T.Updater.Version, _ = O, new Promise(async (W, c) => {
        Z("Downloading the latest updater...");
        if (U(_) === true) {
          const W = n.join(i, _);
          if (k.existsSync(W) === true) {
            k.rmSync(W, {
              recursive: true
            });
          }
        }
        const o = n.join(i, E);
        if (k.existsSync(o) === true) {
          k.rmSync(o, {
            recursive: true
          });
        }
        k.mkdirSync(o, {
          recursive: true,
          mode: 493
        });
        const e = n.join(l, "Updater" + n.extname(X.pathname));
        if (k.existsSync(l) === false) {
          k.mkdirSync(l, {
            recursive: true,
            mode: 493
          });
        } else if (k.existsSync(e) === true) {
          k.rmSync(e);
        }
        let a;
        let m;
        try {
          const {
            headers: W,
            body: c
          } = await C.request(X, {
            headers: {
              authorization: z(X),
              "user-agent": S
            },
            throwOnError: true
          });
          a = W["content-length"];
          m = c;
        } catch (O) {
          return c(O ?? "Failed to download the updater");
        }
        let r = 0;
        m.on("data", W => {
          r += W.length;
          V(r / a * 100);
        });
        const P = k.createWriteStream(e);
        P.once("close", async () => {
          try {
            await (a = e, m = o, C = g, r = E, new Promise((W, c) => {
              w();
              Z("Extracting updater...");
              const o = {
                $progress: true,
                $bin: G
              };
              const t = s.extractFull(a, m, o);
              t.on("progress", W => {
                V(W.percent);
              });
              t.once("error", W => {
                t.removeAllListeners("end");
                if (k.existsSync(a) === true) {
                  k.rmSync(a);
                }
                c(W);
              });
              t.once("end", () => {
                if (k.existsSync(a) === true) {
                  k.rmSync(a);
                }
                if (R !== "windows") {
                  const W = n.join(m, H);
                  if (k.existsSync(W) === true) {
                    k.chmodSync(W, 493);
                  }
                }
                D("Updater", C, r);
                W();
              });
            }));
            W();
          } catch (P) {
            c(P ?? "Failed to extract the updater");
          }
          var a;
          var m;
          var C;
          var r;
        });
        m.pipe(P);
      }));
      O = T.Updater.Version;
    } catch (PW) {
      return v("Failed to download the updater", PW);
    }
  }
  var X;
  var g;
  var E;
  var _;
  var WW;
  var cW;
  var dW;
  var oW;
  var tW;
  var kW;
  var nW;
  var eW;
  var aW;
  var mW;
  var CW;
  if (U(T.Launcher?.Version) === true && U(T.Launcher?.Download) === true && (p === "launcher" || P === null || P !== T.Launcher.Version)) {
    try {
      return await (WW = new URL(T.Launcher.Download), cW = T.Launcher.Version, dW = O, new Promise(async (d, o) => {
        Z("Downloading the latest launcher...");
        const e = n.join(l, "Launcher");
        if (k.existsSync(e) === true) {
          const W = R === "macos" ? n.join(e, "Contents", "Resources", "app.asar") : n.join(e, "resources", "app.asar");
          if (k.existsSync(W) === true) {
            k.unlinkSync(W);
          }
          k.rmSync(e, {
            recursive: true
          });
        }
        k.mkdirSync(e, {
          recursive: true,
          mode: 493
        });
        const r = n.join(l, "Launcher" + n.extname(WW.pathname));
        if (k.existsSync(l) === false) {
          k.mkdirSync(l, {
            recursive: true,
            mode: 493
          });
        } else if (k.existsSync(r) === true) {
          k.rmSync(r);
        }
        let P;
        let O;
        try {
          const {
            headers: W,
            body: c
          } = await C.request(WW, {
            headers: {
              authorization: z(WW),
              "user-agent": S
            },
            throwOnError: true
          });
          P = W["content-length"];
          O = c;
        } catch (f) {
          return o(f ?? "Failed to download the launcher");
        }
        let Q = 0;
        O.on("data", W => {
          Q += W.length;
          V(Q / P * 100);
        });
        const N = k.createWriteStream(r);
        N.once("close", async () => {
          try {
            await (C = r, P = e, S = cW, O = dW, new Promise((d, o) => {
              w();
              Z("Extracting launcher update...");
              const e = {
                $progress: true,
                $bin: G
              };
              const m = s.extractFull(C, P, e);
              m.on("progress", W => {
                V(W.percent);
              });
              m.once("error", W => {
                m.removeAllListeners("end");
                if (k.existsSync(C) === true) {
                  k.rmSync(C);
                }
                o(W);
              });
              m.once("end", () => {
                if (k.existsSync(C) === true) {
                  k.rmSync(C);
                }
                (function (d, o, t) {
                  if (d === null) {
                    return v("Unable to locate the updater service", undefined, "updater");
                  }
                  const m = n.join(i, d, H);
                  if (k.existsSync(m) === false) {
                    return v("Unable to locate the updater service", undefined, "updater");
                  }
                  L("Restarting the launcher...");
                  const C = c.isPackaged === true ? J : R !== "macos" ? n.join(J, "testing") : n.join(J, "testing", "Polytoria.app");
                  const s = R !== "macos" ? n.join(C, n.basename(u)) : n.join(C, "Contents", "MacOS", n.basename(u));
                  const r = process.argv.slice(c.isPackaged === true ? 1 : 2);
                  const P = [m, "--kill", process.pid, "--input", o, "--output", C, "--version", t, "--relaunchPath", s, "--relaunchArgs", ...r];
                  setTimeout(() => {
                    process.once("exit", () => {
                      if (R === "windows") {
                        a.spawn(P[0], P.slice(1), {
                          detached: true,
                          stdio: "ignore",
                          windowsHide: true
                        }).unref();
                      } else if (R === "macos") {
                        a.spawn("osascript", ["-e", "do shell script \"" + P.join(" ") + "\" with prompt \"Polytoria launcher needs to update.\" with administrator privileges"], {
                          detached: true,
                          stdio: "ignore"
                        }).unref();
                      } else {
                        a.spawn("pkexec", ["--disable-internal-agent", ...P], {
                          detached: true,
                          stdio: "ignore"
                        }).unref();
                      }
                    });
                    c.quit();
                  }, 3000);
                })(O, P, S);
                d();
              });
            }));
            d();
          } catch (Q) {
            o(Q ?? "Failed to extract the launcher");
          }
          var C;
          var P;
          var S;
          var O;
        });
        O.pipe(N);
      }));
    } catch (SW) {
      return v("Failed to download the launcher", SW);
    }
  }
  if (o === true || t === true) {
    if (U(T.Client?.Version) === true && U(T.Client?.Download) === true && (p === "client" || Q === null || Q !== T.Client.Version)) {
      try {
        await (eW = new URL(T.Client.Download), aW = T.Client.Release, mW = T.Client.Version, CW = Q, new Promise(async (W, c) => {
          Z("Downloading the latest client...");
          if (U(CW) === true) {
            const W = n.join(N, CW);
            if (k.existsSync(W) === true) {
              k.rmSync(W, {
                recursive: true
              });
            }
          }
          const o = n.join(N, mW);
          if (k.existsSync(o) === true) {
            k.rmSync(o, {
              recursive: true
            });
          }
          k.mkdirSync(o, {
            recursive: true,
            mode: 493
          });
          const e = n.join(l, "Client" + n.extname(eW.pathname));
          if (k.existsSync(l) === false) {
            k.mkdirSync(l, {
              recursive: true,
              mode: 493
            });
          } else if (k.existsSync(e) === true) {
            k.rmSync(e);
          }
          let a;
          let m;
          try {
            const {
              headers: W,
              body: c
            } = await C.request(eW, {
              headers: {
                authorization: z(eW),
                "user-agent": S
              },
              throwOnError: true
            });
            a = W["content-length"];
            m = c;
          } catch (O) {
            return c(O ?? "Failed to download the client");
          }
          let r = 0;
          m.on("data", W => {
            r += W.length;
            V(r / a * 100);
          });
          const P = k.createWriteStream(e);
          P.once("close", async () => {
            try {
              await (a = e, m = o, C = aW, r = mW, new Promise((W, c) => {
                w();
                Z("Extracting client update...");
                const o = {
                  $progress: true,
                  $bin: G
                };
                const t = s.extractFull(a, m, o);
                t.on("progress", W => {
                  V(W.percent);
                });
                t.once("error", W => {
                  t.removeAllListeners("end");
                  if (k.existsSync(a) === true) {
                    k.rmSync(a);
                  }
                  c(W);
                });
                t.once("end", () => {
                  if (k.existsSync(a) === true) {
                    k.rmSync(a);
                  }
                  if (R !== "windows") {
                    const W = n.join(m, q);
                    if (k.existsSync(W) === true) {
                      k.chmodSync(W, 493);
                    }
                  }
                  D("Client", C, r);
                  W();
                });
              }));
              W();
            } catch (P) {
              c(P ?? "Failed to extract the client");
            }
            var a;
            var m;
            var C;
            var r;
          });
          m.pipe(P);
        }));
        Q = T.Client.Version;
      } catch (OW) {
        return v("Failed to download the client", OW);
      }
    }
    j(Q, t);
  } else if (e === true) {
    if (U(T.Creator?.Version) === true && U(T.Creator?.Download) === true && (p === "creator" || h === null || h !== T.Creator.Version)) {
      try {
        await (oW = new URL(T.Creator.Download), tW = T.Creator.Release, kW = T.Creator.Version, nW = h, new Promise(async (W, c) => {
          Z("Downloading the latest creator...");
          if (U(nW) === true) {
            const W = n.join(f, nW);
            if (k.existsSync(W) === true) {
              k.rmSync(W, {
                recursive: true
              });
            }
          }
          const o = n.join(f, kW);
          if (k.existsSync(o) === true) {
            k.rmSync(o, {
              recursive: true
            });
          }
          k.mkdirSync(o, {
            recursive: true,
            mode: 493
          });
          const e = n.join(l, "Creator" + n.extname(oW.pathname));
          if (k.existsSync(l) === false) {
            k.mkdirSync(l, {
              recursive: true,
              mode: 493
            });
          } else if (k.existsSync(e) === true) {
            k.rmSync(e);
          }
          let a;
          let m;
          try {
            const {
              headers: W,
              body: c
            } = await C.request(oW, {
              headers: {
                authorization: z(oW),
                "user-agent": S
              },
              throwOnError: true
            });
            a = W["content-length"];
            m = c;
          } catch (O) {
            return c(O ?? "Failed to download the creator");
          }
          let r = 0;
          m.on("data", W => {
            r += W.length;
            V(r / a * 100);
          });
          const P = k.createWriteStream(e);
          P.once("close", async () => {
            try {
              await (a = e, m = o, C = tW, r = kW, new Promise((W, c) => {
                w();
                Z("Extracting creator update...");
                const o = {
                  $progress: true,
                  $bin: G
                };
                const t = s.extractFull(a, m, o);
                t.on("progress", W => {
                  V(W.percent);
                });
                t.once("error", W => {
                  t.removeAllListeners("end");
                  if (k.existsSync(a) === true) {
                    k.rmSync(a);
                  }
                  c(W);
                });
                t.once("end", () => {
                  if (k.existsSync(a) === true) {
                    k.rmSync(a);
                  }
                  if (R !== "windows") {
                    const W = n.join(m, y);
                    if (k.existsSync(W) === true) {
                      k.chmodSync(W, 493);
                    }
                  }
                  D("Creator", C, r);
                  W();
                });
              }));
              W();
            } catch (P) {
              c(P ?? "Failed to extract the creator");
            }
            var a;
            var m;
            var C;
            var r;
          });
          m.pipe(P);
        }));
        h = T.Creator.Version;
      } catch (QW) {
        return v("Failed to download the creator", QW);
      }
    }
    Y(h);
  }
}
function $(c, d, o) {
  if (k.existsSync(c) === false) {
    return;
  }
  const a = k.readdirSync(c, {
    withFileTypes: true
  });
  if (a.every(W => W.isDirectory() === true) === false) {
    const W = n.join(c, d);
    if (k.existsSync(W) === false) {
      k.mkdirSync(W, {
        recursive: true,
        mode: 493
      });
    }
    for (const o of a) {
      if (o.name === d) {
        continue;
      }
      const e = n.join(c, o.name);
      const a = n.join(W, o.name);
      if (k.existsSync(a) === true) {
        k.rmSync(a, {
          recursive: true
        });
      }
      k.renameSync(e, a);
    }
    if (R !== "windows") {
      const c = n.join(W, o);
      if (k.existsSync(c) === true) {
        k.chmodSync(c, 493);
      }
    }
  }
}
function j(d, o) {
  if (d === null) {
    return v("Unable to locate the client installation", undefined, "client");
  }
  const e = n.join(N, d, q);
  if (k.existsSync(e) === false) {
    return v("Unable to locate the client installation", undefined, "client");
  }
  L("Launching the client...");
  setTimeout(() => {
    const d = n.parse(e);
    let k;
    if (R === "windows") {
      k = a.spawn("taskkill", ["/f", "/im", d.base], {
        windowsHide: true,
        stdio: "ignore"
      });
    } else {
      k = a.spawn("pkill", ["-9", d.name], {
        stdio: "ignore"
      });
    }
    k.on("exit", () => {
      const t = o === true ? ["-solo", M.map] : ["-network", "client", "-token", M.token];
      process.once("exit", () => {
        a.spawn(e, t, {
          detached: true,
          stdio: "ignore"
        }).unref();
      });
      c.quit();
    });
  }, 3000);
}
function Y(d) {
  if (d === null) {
    return v("Unable to locate the creator installation", undefined, "creator");
  }
  const t = n.join(f, d, y);
  if (k.existsSync(t) === false) {
    return v("Unable to locate the creator installation", undefined, "creator");
  }
  L("Launching the creator...");
  setTimeout(() => {
    process.once("exit", () => {
      a.spawn(t, ["-token", M.token], {
        detached: true,
        stdio: "ignore"
      }).unref();
    });
    c.quit();
  }, 3000);
}
c.on("activate", () => {
  if (o.getAllWindows().length === 0) {
    B();
  }
});
c.once("window-all-closed", () => {
  c.quit();
});
c.once("open-url", (c, d) => {
  c.preventDefault();
  process.argv.push(d);
});
c.whenReady().then(() => {
  B();
});
t.on("reinstall", async (c, d) => {
  await async function () {
    await x?.webContents.send("resetUI");
  }();
  p = d;
  await E();
  p = undefined;
});