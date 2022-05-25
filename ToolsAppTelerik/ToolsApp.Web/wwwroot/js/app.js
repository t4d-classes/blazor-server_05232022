'use strict';

window.app = {
  setFocus(selector) {

    const element = document.querySelector(selector);

    if (element) {
      element.focus();
    }

  },
  setTitle(pageTitle) {
    document.title = pageTitle;
  },
  setupColorsRefresh(dotNetHelper) {

    console.log("setup colors refresh");

    $("#refresh-colors-button").click(async () => {
      console.log("called refresh colors button");
      const colors = await dotNetHelper.invokeMethodAsync("All");
      console.log(colors);
    });
  }
};