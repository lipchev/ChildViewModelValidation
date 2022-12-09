# ChildViewModelValidation
Tested with versions 5.0, 5.12.22 (current) and 6.0.0-alpha1068 of Catel.MVVM:
1. Add a child view model: the initial validation errors are propagated to the parent (`HasErrors` is true).
2. Remove the child view model: the parent is not automatically re-validated (expecting the inverse of 1.).
3. Manually calling Validate (or possibly calling HasErrors from code) is required in order for the property notification to actually occur.

![image](https://user-images.githubusercontent.com/5253184/206747637-be43ec24-dce9-4eed-b7d0-a101c358d459.png)
![image](https://user-images.githubusercontent.com/5253184/206747689-e5fe0c19-1520-408d-b137-1e61d6991e31.png)
