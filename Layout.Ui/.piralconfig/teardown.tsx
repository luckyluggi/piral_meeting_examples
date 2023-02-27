import { PiletApi } from "appshell";

const microfrontendName = "layout";

export default (app: PiletApi) => {
    app.unregisterApp(microfrontendName);
}