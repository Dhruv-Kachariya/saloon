import { saloonTemplatePage } from './app.po';

describe('saloon App', function() {
  let page: saloonTemplatePage;

  beforeEach(() => {
    page = new saloonTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
