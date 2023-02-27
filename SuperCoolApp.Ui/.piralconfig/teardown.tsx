import { PiletApi } from "appshell";

const microfrontendName = "supercoolapp";

export default (app: PiletApi) => {
    app.unregisterApp(microfrontendName);
}